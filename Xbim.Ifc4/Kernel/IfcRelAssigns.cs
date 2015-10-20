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
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCRELASSIGNS", 902)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcRelAssigns : IfcRelationship, IEqualityComparer<@IfcRelAssigns>, IEquatable<@IfcRelAssigns>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssigns(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObjectDefinition>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObjectDefinition> _relatedObjects;
		private IfcObjectTypeEnum? _relatedObjectsType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcObjectDefinition> @RelatedObjects 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedObjects;
				((IPersistEntity)this).Activate(false);
				return _relatedObjects;
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcObjectTypeEnum? @RelatedObjectsType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedObjectsType;
				((IPersistEntity)this).Activate(false);
				return _relatedObjectsType;
			} 
			set
			{
				SetValue( v =>  _relatedObjectsType = v, _relatedObjectsType, value,  "RelatedObjectsType");
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
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObjectDefinition>( this );
					_relatedObjects.InternalAdd((IfcObjectDefinition)value.EntityVal);
					return;
				case 5: 
                    _relatedObjectsType = (IfcObjectTypeEnum) System.Enum.Parse(typeof (IfcObjectTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : IfcCorrectObjectAssignment(RelatedObjectsType, RelatedObjects);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssigns other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssigns
            var root = (@IfcRelAssigns)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssigns left, @IfcRelAssigns right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssigns left, @IfcRelAssigns right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssigns x, @IfcRelAssigns y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssigns obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}