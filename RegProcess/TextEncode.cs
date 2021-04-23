using System;
using System.IO;
using System.Linq;
using System.Text;

/// <summary> 
/// 获取文件的编码格式 
/// </summary> 
public class TextEncode
{
    public Encoding Encoding { get; private set; }
    public byte[] BOM { get; private set; }
    public string ReadText(string fileName, out Encoding enc)
    {
        var r = ReadText(fileName);
        enc = Encoding;
        return r;
    }
    public string ReadText(string fileName)
    {
        Encoding encoding = null;

        byte[] bytes = File.ReadAllBytes(fileName);

        int bomLen = 0;
        if (bytes.Length > 1)
        {
            if (bytes[0] == 0xFE && bytes[1] == 0xFF) //UTF-16（大端序）
            {
                encoding = new UnicodeEncoding(true, true);
                bomLen = 2;
            }
            else if (bytes[0] == 0xFF && bytes[1] == 0xFE) //UTF-16（小端序）
            {
                encoding = new UnicodeEncoding(false, true);
                bomLen = 2;
            }
        }
        if (encoding == null && bytes.Length > 2)
        {
            if ((bytes[0] == 0xEF && bytes[1] == 0xBB && bytes[2] == 0xBF)) //UTF-8
            {
                encoding = new UTF8Encoding(true);
                bomLen = 3;
            }
        }
        if (encoding == null && bytes.Length > 3)
        {
            if (bytes[0] == 0x00 && bytes[1] == 0x00 && bytes[2] == 0xFE && bytes[3] == 0xFF) //UTF-32（大端序）
            {
                encoding = new UTF32Encoding(true, true);
                bomLen = 4;
            }
            else if (bytes[0] == 0xFF && bytes[1] == 0xFE && bytes[2] == 0x00 && bytes[3] == 0x00) //UTF-32（小端序）
            {
                encoding = new UTF32Encoding(false, true);
                bomLen = 4;
            }
        }

        if (encoding == null && IsUTF8Bytes(bytes))
        {
            encoding = Encoding.UTF8; //UTF8无BOM
        }
        if (encoding == null) encoding = Encoding.Default;
        Encoding = encoding;

        BOM = new byte[bomLen];
        Array.Copy(bytes, BOM, bomLen);

        return encoding.GetString(bytes, bomLen, bytes.Length - bomLen);
    }

    /// <summary> 
    /// 判断是否是不带 BOM 的 UTF8 格式 
    /// </summary> 
    /// <param name="data"></param> 
    /// <returns></returns> 
    private bool IsUTF8Bytes(byte[] data)
    {
        int charByteCounter = 1; //计算当前正分析的字符应还有的字节数 
        byte curByte; //当前分析的字节. 
        for (int i = 0; i < data.Length; i++)
        {
            curByte = data[i];
            if (curByte == 0) throw new FormatException("非预期的byte格式");
            if (charByteCounter == 1)
            {
                if (curByte >= 0x80)
                {
                    //判断当前 
                    while (((curByte <<= 1) & 0x80) != 0)
                    {
                        charByteCounter++;
                    }
                    //标记位首位若为非0 则至少以2个1开始 如:110XXXXX...........1111110X 
                    if (charByteCounter == 1 || charByteCounter > 6)
                    {
                        return false;
                    }
                }
            }
            else
            {
                //若是UTF-8 此时第一位必须为1 
                if ((curByte & 0xC0) != 0x80)
                {
                    return false;
                }
                charByteCounter--;
            }
        }
        if (charByteCounter > 1)
        {
            throw new FormatException("非预期的byte格式");
        }
        return true;
    }

    /// <summary>
    /// 已相同的Encoding和BOM再次写入
    /// </summary>
    public void WriteBySameEncoding(string fileName, string content)
    {
        if (BOM == null)
        {
            throw new Exception("需要先调用ReadText方法");
        }
        using (var file = File.Create(fileName))
        {
            file.Write(BOM, 0, BOM.Length);
            var bytes = Encoding.GetBytes(content);
            file.Write(bytes, 0, bytes.Length);
        }
    }

}

