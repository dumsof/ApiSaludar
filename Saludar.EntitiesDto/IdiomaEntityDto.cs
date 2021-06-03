﻿namespace Saludar.EntitiesDto
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class IdiomaEntityDto
    {
        [Key]
        public Guid IdIdioma { get; set; }

        public int Ordenado { get; set; }

        public string DescripcionIdioma { get; set; }
    }
}