using System;
using Microsoft.Extensions.Logging;
using Xbim.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class IfcBlobTexture : IExpressValidatable
	{
		public enum IfcBlobTextureClause
		{
			WR11,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcBlobTextureClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcBlobTextureClause.WR11:
						retVal = Functions.NewArray("BMP", "JPG", "GIF", "PNG").Contains(this.RasterFormat);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Xbim.Ifc2x3.PresentationAppearanceResource.IfcBlobTexture>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcBlobTexture.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcBlobTextureClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcBlobTexture.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
