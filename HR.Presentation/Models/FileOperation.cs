namespace HR.Presentation.Models;

public static class FileOperation
{
    public static string ReturnFileName(IFormFile file, string saveFile, IWebHostEnvironment hostEnvironment)
    {

        if (file != null && file.Length > 0)
        {
            string dosyaAdi = "";

            dosyaAdi = Path.GetFileName(file.FileName);
            string dosyaUzantisi = Path.GetExtension(dosyaAdi);
            var dosyaYolu = Path.Combine(hostEnvironment.WebRootPath, saveFile);
            dosyaAdi = Guid.NewGuid().ToString() + dosyaUzantisi;
            var dosyaYoluTam = Path.Combine(dosyaYolu, dosyaAdi);

            using (var fileStream = new FileStream(dosyaYoluTam, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return dosyaAdi;

        }
        else
        {
            return string.Empty;
        }


    }
}
