using System.IO.Compression;

namespace VerifyZipSample;

public static class ZipSample
{
    public static async Task Populate(Stream stream)
    {
        using var zipOutputStream = new ZipArchive(stream, ZipArchiveMode.Create, true);

        var entry = zipOutputStream.CreateEntry("123");

        await using var entryStream = entry.Open();

        var buffer = new byte[] { 1, 2, 3, 4 };

        await entryStream.WriteAsync(buffer);
    }
}