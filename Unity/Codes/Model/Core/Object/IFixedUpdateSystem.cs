using System;

namespace ET
{
	public interface IFixedUpdateHighSystem : ISystemType
	{
		void Run(object o);
	}

	public interface IFixedUpdateLowSystem : ISystemType
	{
		void Run(object o);
	}

	[ObjectSystem]
	public abstract class FixedUpdateHighSystem<T> : IFixedUpdateHighSystem
	{
		public void Run(object o)
		{
			this.FixedUpdate((T)o);
		}

		public Type Type()
		{
			return typeof(T);
		}

		public Type SystemType()
		{
			return typeof(IFixedUpdateHighSystem);
		}

		public abstract void FixedUpdate(T self);
	}

	[ObjectSystem]
	public abstract class FixedUpdateLowSystem<T> : IFixedUpdateLowSystem
	{
		public void Run(object o)
		{
			this.FixedUpdate((T)o);
		}

		public Type Type()
		{
			return typeof(T);
		}

		public Type SystemType()
		{
			return typeof(IFixedUpdateLowSystem);
		}

		public abstract void FixedUpdate(T self);
	}
}
