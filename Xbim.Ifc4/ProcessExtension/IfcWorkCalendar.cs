// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.DateTimeResource;
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
    /// Readonly interface for IfcWorkCalendar
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWorkCalendar : IIfcControl
	{
		IEnumerable<IIfcWorkTime> @WorkingTimes { get; }
		IEnumerable<IIfcWorkTime> @ExceptionTimes { get; }
		IfcWorkCalendarTypeEnum? @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc4.ProcessExtension
{
	[ExpressType("IfcWorkCalendar", 1318)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkCalendar : IfcControl, IInstantiableEntity, IIfcWorkCalendar, IEquatable<@IfcWorkCalendar>
	{
		#region IIfcWorkCalendar explicit implementation
		IEnumerable<IIfcWorkTime> IIfcWorkCalendar.WorkingTimes { get { return @WorkingTimes; } }	
		IEnumerable<IIfcWorkTime> IIfcWorkCalendar.ExceptionTimes { get { return @ExceptionTimes; } }	
		IfcWorkCalendarTypeEnum? IIfcWorkCalendar.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkCalendar(IModel model) : base(model) 		{ 
			Model = model; 
			_workingTimes = new OptionalItemSet<IfcWorkTime>( this, 0,  7);
			_exceptionTimes = new OptionalItemSet<IfcWorkTime>( this, 0,  8);
		}

		#region Explicit attribute fields
		private OptionalItemSet<IfcWorkTime> _workingTimes;
		private OptionalItemSet<IfcWorkTime> _exceptionTimes;
		private IfcWorkCalendarTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 19)]
		public OptionalItemSet<IfcWorkTime> @WorkingTimes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _workingTimes;
				((IPersistEntity)this).Activate(false);
				return _workingTimes;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1, 20)]
		public OptionalItemSet<IfcWorkTime> @ExceptionTimes 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _exceptionTimes;
				((IPersistEntity)this).Activate(false);
				return _exceptionTimes;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 21)]
		public IfcWorkCalendarTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 9);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_workingTimes.InternalAdd((IfcWorkTime)value.EntityVal);
					return;
				case 7: 
					_exceptionTimes.InternalAdd((IfcWorkTime)value.EntityVal);
					return;
				case 8: 
                    _predefinedType = (IfcWorkCalendarTypeEnum) System.Enum.Parse(typeof (IfcWorkCalendarTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkCalendar other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcWorkCalendar
            var root = (@IfcWorkCalendar)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcWorkCalendar left, @IfcWorkCalendar right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcWorkCalendar left, @IfcWorkCalendar right)
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