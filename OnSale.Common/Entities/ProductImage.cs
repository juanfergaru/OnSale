﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://onsalewebjf.azurewebsites.net/images/noimage.png"
            : $"https://onsalegalery.blob.core.windows.net/products/{ImageId}";
    }

}
