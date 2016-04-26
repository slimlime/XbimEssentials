// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextLiteral
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextLiteral : IIfcGeometricRepresentationItem
	{
		IfcPresentableText @Literal { get; }
		IIfcAxis2Placement @Placement { get; }
		IfcTextPath @Path { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationDefinitionResource
{
	[ExpressType("IfcTextLiteral", 29)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextLiteral : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcTextLiteral, IEquatable<@IfcTextLiteral>
	{
		#region IIfcTextLiteral explicit implementation
		IfcPresentableText IIfcTextLiteral.Literal { get { return @Literal; } }	
		IIfcAxis2Placement IIfcTextLiteral.Placement { get { return @Placement; } }	
		IfcTextPath IIfcTextLiteral.Path { get { return @Path; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextLiteral(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPresentableText _literal;
		private IfcAxis2Placement _placement;
		private IfcTextPath _path;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 3)]
		public IfcPresentableText @Literal 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _literal;
				((IPersistEntity)this).Activate(false);
				return _literal;
			} 
			set
			{
				SetValue( v =>  _literal = v, _literal, value,  "Literal", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcAxis2Placement @Placement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _placement;
				((IPersistEntity)this).Activate(false);
				return _placement;
			} 
			set
			{
				SetValue( v =>  _placement = v, _placement, value,  "Placement", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 5)]
		public IfcTextPath @Path 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _path;
				((IPersistEntity)this).Activate(false);
				return _path;
			} 
			set
			{
				SetValue( v =>  _path = v, _path, value,  "Path", 3);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_literal = value.StringVal;
					return;
				case 1: 
					_placement = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 2: 
                    _path = (IfcTextPath) System.Enum.Parse(typeof (IfcTextPath), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextLiteral other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextLiteral
            var root = (@IfcTextLiteral)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextLiteral left, @IfcTextLiteral right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextLiteral left, @IfcTextLiteral right)
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