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
    /// Readonly interface for IfcLine
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLine : IIfcCurve
	{
		IIfcCartesianPoint @Pnt { get; }
		IIfcVector @Dir { get; }
	
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IfcLine", 272)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLine : IfcCurve, IInstantiableEntity, IIfcLine, IEquatable<@IfcLine>
	{
		#region IIfcLine explicit implementation
		IIfcCartesianPoint IIfcLine.Pnt { get { return @Pnt; } }	
		IIfcVector IIfcLine.Dir { get { return @Dir; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLine(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _pnt;
		private IfcVector _dir;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 3)]
		public IfcCartesianPoint @Pnt 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pnt;
				((IPersistEntity)this).Activate(false);
				return _pnt;
			} 
			set
			{
				SetValue( v =>  _pnt = v, _pnt, value,  "Pnt", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 4)]
		public IfcVector @Dir 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dir;
				((IPersistEntity)this).Activate(false);
				return _dir;
			} 
			set
			{
				SetValue( v =>  _dir = v, _dir, value,  "Dir", 2);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_pnt = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 1: 
					_dir = (IfcVector)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLine other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLine
            var root = (@IfcLine)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLine left, @IfcLine right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLine left, @IfcLine right)
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