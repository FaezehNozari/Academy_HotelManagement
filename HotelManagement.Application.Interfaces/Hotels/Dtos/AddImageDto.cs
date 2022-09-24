using System;
using HotelManagement.Domain.Models.Models.Hotels.Entities;

namespace HotelManagement.Application.Interfaces.Hotels.Dtos
{
    public class AddImageDto
    {
        public Guid HotelId { get; set; }
        public Image Image { get; set; }
    }
}