﻿using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using System.Collections;

public class TranserToSprite : AssetPostprocessor {

    void OnPreprocessTexture()
    {
        //为需要转换为Sprite类型的图片名称中加如@sprite，用作匹配
        //当匹配到含有@sprite串时才转换图片类型
        if (assetImporter.assetPath.Contains(""))
        {
            //texImpoter是图片的Import Settings对象
            //AssetImporter是TextureImporter的基类
            TextureImporter texImpoter = assetImporter as TextureImporter;
            //TextureImporterType是结构体，包含所有Texture Type
            texImpoter.textureType = TextureImporterType.Sprite;
        }
    }
}