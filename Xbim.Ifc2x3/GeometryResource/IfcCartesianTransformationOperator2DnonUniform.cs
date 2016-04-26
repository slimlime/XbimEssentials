// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCartesianTransformationOperator2DnonUniform
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCartesianTransformationOperator2DnonUniform : IIfcCartesianTransformationOperator2D
	{
		double? @Scale2 { get; }
		double @Scl2  { get ; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcCartesianTransformationOperator2DnonUniform", 147)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianTransformationOperator2DnonUniform : IfcCartesianTransformationOperator2D, IInstantiableEntity, IIfcCartesianTransformationOperator2DnonUniform, IEquatable<@IfcCartesianTransformationOperator2DnonUniform>
	{
		#region IIfcCartesianTransformationOperator2DnonUniform explicit implementation
		double? IIfcCartesianTransformationOperator2DnonUniform.Scale2 { get { return @Scale2; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianTransformationOperator2DnonUniform(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private double? _scale2;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public double? @Scale2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _scale2;
				((IPersistEntity)this).Activate(false);
				return _scale2;
			} 
			set
			{
				SetValue( v =>  _scale2 = v, _scale2, value,  "Scale2", 5);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public double @Scl2 
		{
			get 
			{
				//## Getter for Scl2
                return Scale2 ?? Scl;
				//##
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_scale2 = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianTransformationOperator2DnonUniform other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCartesianTransformationOperator2DnonUniform
            var root = (@IfcCartesianTransformationOperator2DnonUniform)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCartesianTransformationOperator2DnonUniform left, @IfcCartesianTransformationOperator2DnonUniform right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCartesianTransformationOperator2DnonUniform left, @IfcCartesianTransformationOperator2DnonUniform right)
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