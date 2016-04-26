// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedMgmtElements;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProjectOrderRecord
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProjectOrderRecord : IIfcControl
	{
		IEnumerable<IIfcRelAssignsToProjectOrder> @Records { get; }
		IfcProjectOrderRecordTypeEnum @PredefinedType { get; }
	
	}
}

namespace Xbim.Ifc2x3.SharedMgmtElements
{
	[ExpressType("IfcProjectOrderRecord", 697)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProjectOrderRecord : IfcControl, IInstantiableEntity, IIfcProjectOrderRecord, IEquatable<@IfcProjectOrderRecord>
	{
		#region IIfcProjectOrderRecord explicit implementation
		IEnumerable<IIfcRelAssignsToProjectOrder> IIfcProjectOrderRecord.Records { get { return @Records; } }	
		IfcProjectOrderRecordTypeEnum IIfcProjectOrderRecord.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProjectOrderRecord(IModel model) : base(model) 		{ 
			Model = model; 
			_records = new ItemSet<IfcRelAssignsToProjectOrder>( this, 0,  6);
		}

		#region Explicit attribute fields
		private ItemSet<IfcRelAssignsToProjectOrder> _records;
		private IfcProjectOrderRecordTypeEnum _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, 1, -1, 12)]
		public ItemSet<IfcRelAssignsToProjectOrder> @Records 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _records;
				((IPersistEntity)this).Activate(false);
				return _records;
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 13)]
		public IfcProjectOrderRecordTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 7);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_records.InternalAdd((IfcRelAssignsToProjectOrder)value.EntityVal);
					return;
				case 6: 
                    _predefinedType = (IfcProjectOrderRecordTypeEnum) System.Enum.Parse(typeof (IfcProjectOrderRecordTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProjectOrderRecord other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProjectOrderRecord
            var root = (@IfcProjectOrderRecord)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProjectOrderRecord left, @IfcProjectOrderRecord right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProjectOrderRecord left, @IfcProjectOrderRecord right)
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