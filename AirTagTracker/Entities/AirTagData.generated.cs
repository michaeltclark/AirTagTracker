//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.2.1.3
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AirTagTracker
{
   public partial class AirTagData
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public AirTagData()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_uploadsession0"></param>
      public AirTagData(global::AirTagTracker.UploadSession _uploadsession0) : this()
      {
         if (_uploadsession0 == null) throw new ArgumentNullException(nameof(_uploadsession0));
         _uploadsession0.AirTagDatas.Add(this);

      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_uploadsession0"></param>
      public static AirTagData Create(global::AirTagTracker.UploadSession _uploadsession0)
      {
         return new AirTagData(_uploadsession0);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Indexed, Required
      /// Unique identifier
      /// </summary>
      [Key]
      [Required]
      [System.ComponentModel.Description("Unique identifier")]
      public long Id { get; set; }

      public double? Latitude { get; set; }

      public double? Longitude { get; set; }

      public string TagName { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}

