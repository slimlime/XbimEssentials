// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.SharedBldgElements;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelConnectsPathElements
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelConnectsPathElements : IIfcRelConnectsElements
	{
		IEnumerable<IfcInteger> @RelatingPriorities { get; }
		IEnumerable<IfcInteger> @RelatedPriorities { get; }
		IfcConnectionTypeEnum @RelatedConnectionType { get; }
		IfcConnectionTypeEnum @RelatingConnectionType { get; }
	
	}
}

namespace Xbim.Ifc4.SharedBldgElements
{
	[ExpressType("IfcRelConnectsPathElements", 668)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelConnectsPathElements : IfcRelConnectsElements, IInstantiableEntity, IIfcRelConnectsPathElements, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelConnectsPathElements>
	{
		#region IIfcRelConnectsPathElements explicit implementation
		IEnumerable<IfcInteger> IIfcRelConnectsPathElements.RelatingPriorities { get { return @RelatingPriorities; } }	
		IEnumerable<IfcInteger> IIfcRelConnectsPathElements.RelatedPriorities { get { return @RelatedPriorities; } }	
		IfcConnectionTypeEnum IIfcRelConnectsPathElements.RelatedConnectionType { get { return @RelatedConnectionType; } }	
		IfcConnectionTypeEnum IIfcRelConnectsPathElements.RelatingConnectionType { get { return @RelatingConnectionType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelConnectsPathElements(IModel model) : base(model) 		{ 
			Model = model; 
			_relatingPriorities = new ItemSet<IfcInteger>( this, 0,  8);
			_relatedPriorities = new ItemSet<IfcInteger>( this, 0,  9);
		}

		#region Explicit attribute fields
		private ItemSet<IfcInteger> _relatingPriorities;
		private ItemSet<IfcInteger> _relatedPriorities;
		private IfcConnectionTypeEnum _relatedConnectionType;
		private IfcConnectionTypeEnum _relatingConnectionType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 0, -1, 8)]
		public ItemSet<IfcInteger> @RelatingPriorities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingPriorities;
				((IPersistEntity)this).Activate(false);
				return _relatingPriorities;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 0, -1, 9)]
		public ItemSet<IfcInteger> @RelatedPriorities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedPriorities;
				((IPersistEntity)this).Activate(false);
				return _relatedPriorities;
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 10)]
		public IfcConnectionTypeEnum @RelatedConnectionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedConnectionType;
				((IPersistEntity)this).Activate(false);
				return _relatedConnectionType;
			} 
			set
			{
				SetValue( v =>  _relatedConnectionType = v, _relatedConnectionType, value,  "RelatedConnectionType", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 11)]
		public IfcConnectionTypeEnum @RelatingConnectionType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingConnectionType;
				((IPersistEntity)this).Activate(false);
				return _relatingConnectionType;
			} 
			set
			{
				SetValue( v =>  _relatingConnectionType = v, _relatingConnectionType, value,  "RelatingConnectionType", 11);
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
					_relatingPriorities.InternalAdd(value.IntegerVal);
					return;
				case 8: 
					_relatedPriorities.InternalAdd(value.IntegerVal);
					return;
				case 9: 
                    _relatedConnectionType = (IfcConnectionTypeEnum) System.Enum.Parse(typeof (IfcConnectionTypeEnum), value.EnumVal, true);
					return;
				case 10: 
                    _relatingConnectionType = (IfcConnectionTypeEnum) System.Enum.Parse(typeof (IfcConnectionTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelConnectsPathElements other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelConnectsPathElements
            var root = (@IfcRelConnectsPathElements)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelConnectsPathElements left, @IfcRelConnectsPathElements right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelConnectsPathElements left, @IfcRelConnectsPathElements right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ConnectionGeometry != null)
					yield return @ConnectionGeometry;
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingElement != null)
					yield return @RelatingElement;
				if (@RelatedElement != null)
					yield return @RelatedElement;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}