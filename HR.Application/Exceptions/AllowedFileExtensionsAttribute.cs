using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Application.Exceptions;

public class AllowedFileExtensionsAttribute : ValidationAttribute
{
    private readonly string[] _extensions;

    public AllowedFileExtensionsAttribute(string[] extensions)
    {
        _extensions = extensions;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is IFormFile file)
        {
            var extension = Path.GetExtension(file.FileName);

            if (extension != null && _extensions.Contains(extension.ToLower()))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(GetErrorMessage());
            }
        }

        return ValidationResult.Success; // Dosya boşsa doğrulamadan geç
    }

    public string GetErrorMessage()
    {
        return "Geçersiz dosya uzantısı. Sadece PNG ve JPEG uzantılı dosyalar kabul edilir.";
    }
}