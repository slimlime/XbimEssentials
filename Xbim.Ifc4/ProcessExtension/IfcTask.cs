// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.DateTimeResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.ProcessExtension;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTask
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTask : IIfcProcess
	{
		IfcLabel? @Status { get; }
		IfcLabel? @WorkMethod { get; }
		IfcBoolean @IsMilestone { get; }
		IfcInteger? @Priority { get; }
		IIfcTaskTime @TaskTime { get; }
		IfcTaskTypeEnum? @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IfcTask", 72)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTask : IfcProcess, IInstantiableEntity, IIfcTask, IEquatable<@IfcTask>
	{
		#region IIfcTask explicit implementation
		IfcLabel? IIfcTask.Status { get { return @Status; } }	
		IfcLabel? IIfcTask.WorkMethod { get { return @WorkMethod; } }	
		IfcBoolean IIfcTask.IsMilestone { get { return @IsMilestone; } }	
		IfcInteger? IIfcTask.Priority { get { return @Priority; } }	
		IIfcTaskTime IIfcTask.TaskTime { get { return @TaskTime; } }	
		IfcTaskTypeEnum? IIfcTask.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTask(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _status;
		private IfcLabel? _workMethod;
		private IfcBoolean _isMilestone;
		private IfcInteger? _priority;
		private IfcTaskTime _taskTime;
		private IfcTaskTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public IfcLabel? @Status 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _status;
				((IPersistEntity)this).Activate(false);
				return _status;
			} 
			set
			{
				SetValue( v =>  _status = v, _status, value,  "Status", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 23)]
		public IfcLabel? @WorkMethod 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _workMethod;
				((IPersistEntity)this).Activate(false);
				return _workMethod;
			} 
			set
			{
				SetValue( v =>  _workMethod = v, _workMethod, value,  "WorkMethod", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 24)]
		public IfcBoolean @IsMilestone 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isMilestone;
				((IPersistEntity)this).Activate(false);
				return _isMilestone;
			} 
			set
			{
				SetValue( v =>  _isMilestone = v, _isMilestone, value,  "IsMilestone", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 25)]
		public IfcInteger? @Priority 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _priority;
				((IPersistEntity)this).Activate(false);
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 26)]
		public IfcTaskTime @TaskTime 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _taskTime;
				((IPersistEntity)this).Activate(false);
				return _taskTime;
			} 
			set
			{
				SetValue( v =>  _taskTime = v, _taskTime, value,  "TaskTime", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 27)]
		public IfcTaskTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 13);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_status = value.StringVal;
					return;
				case 8: 
					_workMethod = value.StringVal;
					return;
				case 9: 
					_isMilestone = value.BooleanVal;
					return;
				case 10: 
					_priority = value.IntegerVal;
					return;
				case 11: 
					_taskTime = (IfcTaskTime)(value.EntityVal);
					return;
				case 12: 
                    _predefinedType = (IfcTaskTypeEnum) System.Enum.Parse(typeof (IfcTaskTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTask other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTask
            var root = (@IfcTask)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTask left, @IfcTask right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTask left, @IfcTask right)
        {
            return !(left == right);
        }

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}