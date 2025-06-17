﻿using System.ComponentModel.DataAnnotations;

namespace Logistics.Shared.DTOs;

public class ImageDTO
{
    [Required] public int ProductId { get; set; }

    [Required] public List<string> Images { get; set; } = null!;
}