using UnityEngine;
using System.Net;
using System.IO;
using System;
public class TestCode : MonoBehaviour
{
    WebClient client;
    string htmlCode;
    void Start()
    {
        client = new WebClient();
        htmlCode = client.DownloadString("https://zen.yandex.ru/video/watch/6185a775b411ca01e4a540f2");
        ParseHTML();
    }
    void ParseHTML()
    {
        string nameTag = "\"application/ld+json\"";
        char[] charNameTage = nameTag.ToCharArray();
        int counter = 0;
        for (int i = 0; i < htmlCode.Length - 1; i++)
        {
            if (htmlCode[i] == charNameTage[counter])
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            if (counter > nameTag.Length - 1)
            {

                string uploadDate = Save(i, "\"uploadDate\":\"");
                string name = Save(i, "\"name\":\"");
                string description = Save(i, "\"description\":\"");
                string url = Save(i, "\"url\":\"");
                string thumbnailUrl = Save(i, "\"thumbnailUrl\":\"");
                print("uploadDate - " + uploadDate);
                print("name - " + name);
                print("description - " + description);
                print("url - " + url);
                print("thumbnailUrl - " + thumbnailUrl);
                break;
            }
        }
    }
    string Save(int number, string tag)
    {
        char[] charNameTag = tag.ToCharArray();
        int counter = 0;
        for (int i = number; i < htmlCode.Length - 1; i++)
        {
            if (htmlCode[i] == charNameTag[counter])
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            if (counter > charNameTag.Length - 1)
            {
                return SaveString(i+1);
            }
        }
        return "Нет результата";
    }
    string SaveString(int number)
    {
        if(number != 0)
        {
            string result = "";
            string stopTag = "\"";
            char[] charStopTage = stopTag.ToCharArray();
            for (int i = number; i < htmlCode.Length-1; i++)
            {
                if (htmlCode[i] == charStopTage[0])
                {
                    return result;
                }
                result += htmlCode[i];
            }
        }
        return "Нет результата";
    }
}