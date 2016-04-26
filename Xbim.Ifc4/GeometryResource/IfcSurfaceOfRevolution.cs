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
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceOfRevolution
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceOfRevolution : IIfcSweptSurface
	{
		IIfcAxis1Placement @AxisPosition { get; }
		Common.Geometry.XbimLine @AxisLine  { get ; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcSurfaceOfRevolution", 109)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceOfRevolution : IfcSweptSurface, IInstantiableEntity, IIfcSurfaceOfRevolution, IEquatable<@IfcSurfaceOfRevolution>
	{
		#region IIfcSurfaceOfRevolution explicit implementation
		IIfcAxis1Placement IIfcSurfaceOfRevolution.AxisPosition { get { return @AxisPosition; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceOfRevolution(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axisPosition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 5)]
		public IfcAxis1Placement @AxisPosition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _axisPosition;
				((IPersistEntity)this).Activate(false);
				return _axisPosition;
			} 
			set
			{
				SetValue( v =>  _axisPosition = v, _axisPosition, value,  "AxisPosition", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public Common.Geometry.XbimLine @AxisLine 
		{
			get 
			{
				//## Getter for AxisLine
                if (AxisPosition != null)
                {
                    return new Common.Geometry.XbimLine
                    {
                        Pnt = new Common.Geometry.XbimPoint3D(AxisPosition.Location.X, AxisPosition.Location.Y, AxisPosition.Location.Z),
                        Orientation = AxisPosition.Z,
                    };
                }
                return null;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_axisPosition = (IfcAxis1Placement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceOfRevolution other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSurfaceOfRevolution
            var root = (@IfcSurfaceOfRevolution)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSurfaceOfRevolution left, @IfcSurfaceOfRevolution right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSurfaceOfRevolution left, @IfcSurfaceOfRevolution right)
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