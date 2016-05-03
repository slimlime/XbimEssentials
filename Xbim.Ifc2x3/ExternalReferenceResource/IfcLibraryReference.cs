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
using Xbim.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLibraryReference
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLibraryReference : IIfcExternalReference, IfcLibrarySelect
	{
		IEnumerable<IIfcLibraryInformation> @ReferenceIntoLibrary {  get; }
	
	}
}

namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcLibraryReference", 598)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLibraryReference : IfcExternalReference, IInstantiableEntity, IIfcLibraryReference, IEquatable<@IfcLibraryReference>
	{
		#region IIfcLibraryReference explicit implementation
		 
		IEnumerable<IIfcLibraryInformation> IIfcLibraryReference.ReferenceIntoLibrary {  get { return @ReferenceIntoLibrary; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLibraryReference(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region Inverse attributes
		[InverseProperty("LibraryReference")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 0, 1, 4)]
		public IEnumerable<IfcLibraryInformation> @ReferenceIntoLibrary 
		{ 
			get 
			{
				return Model.Instances.Where<IfcLibraryInformation>(e => e.LibraryReference != null &&  e.LibraryReference.Contains(this), "LibraryReference", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLibraryReference other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLibraryReference
            var root = (@IfcLibraryReference)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLibraryReference left, @IfcLibraryReference right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLibraryReference left, @IfcLibraryReference right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcLibraryReference left, IfcLibrarySelect right)
		{
			return left == right as @IfcLibraryReference;
		}

		public static bool operator !=(@IfcLibraryReference left, IfcLibrarySelect right)
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