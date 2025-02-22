/******************************************************************************
 * Spine Runtimes Software License v2.5
 *
 * Copyright (c) 2013-2016, Esoteric Software
 * All rights reserved.
 *
 * You are granted a perpetual, non-exclusive, non-sublicensable, and
 * non-transferable license to use, install, execute, and perform the Spine
 * Runtimes software and derivative works solely for personal or internal
 * use. Without the written permission of Esoteric Software (see Section 2 of
 * the Spine Software License Agreement), you may not (a) modify, translate,
 * adapt, or develop new applications using the Spine Runtimes or otherwise
 * create derivative works or improvements of the Spine Runtimes or (b) remove,
 * delete, alter, or obscure any trademarks or any copyright, trademark, patent,
 * or other intellectual property or proprietary rights notices on or in the
 * Software, including any copy thereof. Redistributions in binary or source
 * form must include this license and terms.
 *
 * THIS SOFTWARE IS PROVIDED BY ESOTERIC SOFTWARE "AS IS" AND ANY EXPRESS OR
 * IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF
 * MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO
 * EVENT SHALL ESOTERIC SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
 * SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
 * PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES, BUSINESS INTERRUPTION, OR LOSS OF
 * USE, DATA, OR PROFITS) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER
 * IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 *****************************************************************************/

// Contributed by: Mitch Thompson

#if UNITY_EDITOR

using UnityEngine;
using UnityEditor;
using System;
using System.Collections.Generic;
using System.Reflection;
using Spine;

namespace Spine.Unity.Editor
{
    public struct SpineDrawerValuePair
    {
        public string str;
        public SerializedProperty property;

        public SpineDrawerValuePair(string val, SerializedProperty property)
        {
            this.str = val;
            this.property = property;
        }
    }

    public abstract class SpineTreeItemDrawerBase<T> : PropertyDrawer where T : SpineAttributeBase
    {
        protected SkeletonDataAsset skeletonDataAsset;
        internal const string NoneLabel = "<None>";

        protected T TargetAttribute { get { return (T)attribute; } }
        protected SerializedProperty SerializedProperty { get; private set; }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty = property;

            if (property.propertyType != SerializedPropertyType.String)
            {
                EditorGUI.LabelField(position, "ERROR:", "May only apply to type string");
                return;
            }

            var dataField = property.serializedObject.FindProperty(TargetAttribute.dataField);
            if (dataField != null)
            {
                if (dataField.objectReferenceValue is SkeletonDataAsset)
                {
                    skeletonDataAsset = (SkeletonDataAsset)dataField.objectReferenceValue;
                }
                else if (dataField.objectReferenceValue is ISkeletonComponent)
                {
                    var skeletonComponent = (ISkeletonComponent)dataField.objectReferenceValue;
                    if (skeletonComponent != null)
                        skeletonDataAsset = skeletonComponent.SkeletonDataAsset;
                }
                else
                {
                    EditorGUI.LabelField(position, "ERROR:", "Invalid reference type");
                    return;
                }

            }
            else if (property.serializedObject.targetObject is Component)
            {
                var component = (Component)property.serializedObject.targetObject;
                var skeletonComponent = component.GetComponentInChildren(typeof(ISkeletonComponent)) as ISkeletonComponent;
                if (skeletonComponent != null)
                    skeletonDataAsset = skeletonComponent.SkeletonDataAsset;
            }

            if (skeletonDataAsset == null)
            {
                EditorGUI.LabelField(position, "ERROR:", "Must have reference to a SkeletonDataAsset");
                return;
            }

            position = EditorGUI.PrefixLabel(position, label);

            var propertyStringValue = (property.hasMultipleDifferentValues) ? SpineInspectorUtility.EmDash : property.stringValue;
            if (GUI.Button(position, string.IsNullOrEmpty(propertyStringValue) ? NoneLabel : propertyStringValue, EditorStyles.popup))
                Selector(property);

        }

        public ISkeletonComponent GetTargetSkeletonComponent(SerializedProperty property)
        {
            var dataField = property.serializedObject.FindProperty(TargetAttribute.dataField);

            if (dataField != null)
            {
                var skeletonComponent = dataField.objectReferenceValue as ISkeletonComponent;
                if (dataField.objectReferenceValue != null && skeletonComponent != null) // note the overloaded UnityEngine.Object == null check. Do not simplify.
                    return skeletonComponent;
            }
            else
            {
                var component = property.serializedObject.targetObject as Component;
                if (component != null)
                    return component.GetComponentInChildren(typeof(ISkeletonComponent)) as ISkeletonComponent;
            }

            return null;
        }

        protected virtual void Selector(SerializedProperty property)
        {
            SkeletonData data = skeletonDataAsset.GetSkeletonData(true);
            if (data == null) return;

            var menu = new GenericMenu();
            PopulateMenu(menu, property, this.TargetAttribute, data);
            menu.ShowAsContext();
        }

        protected abstract void PopulateMenu(GenericMenu menu, SerializedProperty property, T targetAttribute, SkeletonData data);

        protected virtual void HandleSelect(object menuItemObject)
        {
            var clickedItem = (SpineDrawerValuePair)menuItemObject;
            clickedItem.property.stringValue = clickedItem.str;
            clickedItem.property.serializedObject.ApplyModifiedProperties();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return 18;
        }

    }

    [CustomPropertyDrawer(typeof(SpineSlot))]
    public class SpineSlotDrawer : SpineTreeItemDrawerBase<SpineSlot>
    {

        protected override void PopulateMenu(GenericMenu menu, SerializedProperty property, SpineSlot targetAttribute, SkeletonData data)
        {
            for (int i = 0; i < data.Slots.Count; i++)
            {
                string name = data.Slots.Items[i].Name;
                if (name.StartsWith(targetAttribute.startsWith, StringComparison.Ordinal))
                {

                    if (targetAttribute.containsBoundingBoxes)
                    {
                        int slotIndex = i;
                        var attachments = new List<Attachment>();
                        foreach (var skin in data.Skins)
                            skin.FindAttachmentsForSlot(slotIndex, attachments);

                        bool hasBoundingBox = false;
                        foreach (var attachment in attachments)
                        {
                            var bbAttachment = attachment as BoundingBoxAttachment;
                            if (bbAttachment != null)
                            {
                                string menuLabel = bbAttachment.IsWeighted() ? name + " (!)" : name;
                                menu.AddItem(new GUIContent(menuLabel), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
                                hasBoundingBox = true;
                                break;
                            }
                        }

                        if (!hasBoundingBox)
                            menu.AddDisabledItem(new GUIContent(name));

                    }
                    else
                    {
                        menu.AddItem(new GUIContent(name), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
                    }

                }

            }
        }

    }

    [CustomPropertyDrawer(typeof(SpineSkin))]
    public class SpineSkinDrawer : SpineTreeItemDrawerBase<SpineSkin>
    {

        protected override void PopulateMenu(GenericMenu menu, SerializedProperty property, SpineSkin targetAttribute, SkeletonData data)
        {
            menu.AddDisabledItem(new GUIContent(skeletonDataAsset.name));
            menu.AddSeparator("");

            for (int i = 0; i < data.Skins.Count; i++)
            {
                string name = data.Skins.Items[i].Name;
                if (name.StartsWith(targetAttribute.startsWith, StringComparison.Ordinal))
                    menu.AddItem(new GUIContent(name), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
            }
        }

    }

    [CustomPropertyDrawer(typeof(SpineAnimation))]
    public class SpineAnimationDrawer : SpineTreeItemDrawerBase<SpineAnimation>
    {
        protected override void PopulateMenu(GenericMenu menu, SerializedProperty property, SpineAnimation targetAttribute, SkeletonData data)
        {
            var animations = skeletonDataAsset.GetAnimationStateData().SkeletonData.Animations;

            // <None> item
            menu.AddItem(new GUIContent(NoneLabel), string.IsNullOrEmpty(property.stringValue), HandleSelect, new SpineDrawerValuePair("", property));

            for (int i = 0; i < animations.Count; i++)
            {
                string name = animations.Items[i].Name;
                if (name.StartsWith(targetAttribute.startsWith, StringComparison.Ordinal))
                    menu.AddItem(new GUIContent(name), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
            }
        }

    }

    [CustomPropertyDrawer(typeof(SpineEvent))]
    public class SpineEventNameDrawer : SpineTreeItemDrawerBase<SpineEvent>
    {
        protected override void PopulateMenu(GenericMenu menu, SerializedProperty property, SpineEvent targetAttribute, SkeletonData data)
        {
            var events = skeletonDataAsset.GetSkeletonData(false).Events;

            // <None> item
            menu.AddItem(new GUIContent(NoneLabel), string.IsNullOrEmpty(property.stringValue), HandleSelect, new SpineDrawerValuePair("", property));

            for (int i = 0; i < events.Count; i++)
            {
                string name = events.Items[i].Name;
                if (name.StartsWith(targetAttribute.startsWith, StringComparison.Ordinal))
                    menu.AddItem(new GUIContent(name), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
            }
        }

    }

    [CustomPropertyDrawer(typeof(SpineAttachment))]
    public class SpineAttachmentDrawer : SpineTreeItemDrawerBase<SpineAttachment>
    {
        protected override void PopulateMenu(GenericMenu menu, SerializedProperty property, SpineAttachment targetAttribute, SkeletonData data)
        {
            ISkeletonComponent skeletonComponent = GetTargetSkeletonComponent(property);
            var validSkins = new List<Skin>();

            if (skeletonComponent != null && targetAttribute.currentSkinOnly)
            {
                var currentSkin = skeletonComponent.Skeleton.Skin;
                if (currentSkin != null)
                    validSkins.Add(currentSkin);
                else
                    validSkins.Add(data.Skins.Items[0]);

            }
            else
            {
                foreach (Skin skin in data.Skins)
                    if (skin != null) validSkins.Add(skin);
            }

            var attachmentNames = new List<string>();
            var placeholderNames = new List<string>();
            string prefix = "";

            if (skeletonComponent != null && targetAttribute.currentSkinOnly)
                menu.AddDisabledItem(new GUIContent((skeletonComponent as Component).gameObject.name + " (Skeleton)"));
            else
                menu.AddDisabledItem(new GUIContent(skeletonDataAsset.name));

            menu.AddSeparator("");
            menu.AddItem(new GUIContent("Null"), property.stringValue == "", HandleSelect, new SpineDrawerValuePair("", property));
            menu.AddSeparator("");

            Skin defaultSkin = data.Skins.Items[0];

            SerializedProperty slotProperty = property.serializedObject.FindProperty(targetAttribute.slotField);
            string slotMatch = "";
            if (slotProperty != null)
            {
                if (slotProperty.propertyType == SerializedPropertyType.String)
                {
                    slotMatch = slotProperty.stringValue.ToLower();
                }
            }

            foreach (Skin skin in validSkins)
            {
                string skinPrefix = skin.Name + "/";

                if (validSkins.Count > 1)
                    prefix = skinPrefix;

                for (int i = 0; i < data.Slots.Count; i++)
                {
                    if (slotMatch.Length > 0 && !(data.Slots.Items[i].Name.ToLower().Contains(slotMatch)))
                        continue;

                    attachmentNames.Clear();
                    placeholderNames.Clear();

                    skin.FindNamesForSlot(i, attachmentNames);
                    if (skin != defaultSkin)
                    {
                        defaultSkin.FindNamesForSlot(i, attachmentNames);
                        skin.FindNamesForSlot(i, placeholderNames);
                    }

                    for (int a = 0; a < attachmentNames.Count; a++)
                    {
                        string attachmentPath = attachmentNames[a];
                        string menuPath = prefix + data.Slots.Items[i].Name + "/" + attachmentPath;
                        string name = attachmentNames[a];

                        if (targetAttribute.returnAttachmentPath)
                            name = skin.Name + "/" + data.Slots.Items[i].Name + "/" + attachmentPath;

                        if (targetAttribute.placeholdersOnly && !placeholderNames.Contains(attachmentPath))
                        {
                            menu.AddDisabledItem(new GUIContent(menuPath));
                        }
                        else
                        {
                            menu.AddItem(new GUIContent(menuPath), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
                        }
                    }

                }
            }
        }

    }

    [CustomPropertyDrawer(typeof(SpineBone))]
    public class SpineBoneDrawer : SpineTreeItemDrawerBase<SpineBone>
    {
        protected override void PopulateMenu(GenericMenu menu, SerializedProperty property, SpineBone targetAttribute, SkeletonData data)
        {
            menu.AddDisabledItem(new GUIContent(skeletonDataAsset.name));
            menu.AddSeparator("");

            for (int i = 0; i < data.Bones.Count; i++)
            {
                string name = data.Bones.Items[i].Name;
                if (name.StartsWith(targetAttribute.startsWith, StringComparison.Ordinal))
                    menu.AddItem(new GUIContent(name), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
            }
        }

    }

    [CustomPropertyDrawer(typeof(SpineAtlasRegion))]
    public class SpineAtlasRegionDrawer : PropertyDrawer
    {
        SerializedProperty atlasProp;

        protected SpineAtlasRegion TargetAttribute { get { return (SpineAtlasRegion)attribute; } }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.propertyType != SerializedPropertyType.String)
            {
                EditorGUI.LabelField(position, "ERROR:", "May only apply to type string");
                return;
            }

            string atlasAssetFieldName = TargetAttribute.atlasAssetField;
            if (string.IsNullOrEmpty(atlasAssetFieldName))
                atlasAssetFieldName = "atlasAsset";

            atlasProp = property.serializedObject.FindProperty(atlasAssetFieldName);

            if (atlasProp == null)
            {
                EditorGUI.LabelField(position, "ERROR:", "Must have AtlasAsset variable!");
                return;
            }
            else if (atlasProp.objectReferenceValue == null)
            {
                EditorGUI.LabelField(position, "ERROR:", "Atlas variable must not be null!");
                return;
            }
            else if (atlasProp.objectReferenceValue.GetType() != typeof(AtlasAsset))
            {
                EditorGUI.LabelField(position, "ERROR:", "Atlas variable must be of type AtlasAsset!");
            }

            position = EditorGUI.PrefixLabel(position, label);

            if (GUI.Button(position, property.stringValue, EditorStyles.popup))
                Selector(property);

        }

        void Selector(SerializedProperty property)
        {
            GenericMenu menu = new GenericMenu();
            AtlasAsset atlasAsset = (AtlasAsset)atlasProp.objectReferenceValue;
            Atlas atlas = atlasAsset.GetAtlas();
            FieldInfo field = typeof(Atlas).GetField("regions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            List<AtlasRegion> regions = (List<AtlasRegion>)field.GetValue(atlas);

            for (int i = 0; i < regions.Count; i++)
            {
                string name = regions[i].name;
                menu.AddItem(new GUIContent(name), name == property.stringValue, HandleSelect, new SpineDrawerValuePair(name, property));
            }

            menu.ShowAsContext();
        }

        static void HandleSelect(object val)
        {
            var pair = (SpineDrawerValuePair)val;
            pair.property.stringValue = pair.str;
            pair.property.serializedObject.ApplyModifiedProperties();
        }

    }

}

#endif
