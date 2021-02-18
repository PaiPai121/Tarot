using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAkanaCard
{
    public string Name; // 卡牌名称
    public string [] KeyWords;  // 关键字
    public Star Star; // 星象
    public Element Element; // 元素
    public string CardDescription; // 卡牌描述
    public string[] upright; // 正位含义
    public string[] reversed; // 逆位含义
    public static readonly string[] means = {"基本含义","恋爱婚姻","工作学业","人机财富","健康生活","其它"};
    /// <summary>
    /// 卡牌名称、关键字、星象、元素、卡牌描述、正位含义、逆位含义
    /// </summary>
    public BigAkanaCard(string _name,string [] _KeyWords,Star _star,Element _element, string _CardDescription,string[] _upright,string[] _reversed)
    {

        Name = _name;
        KeyWords = _KeyWords;
        Star = _star;
        Element = _element;
        CardDescription = _CardDescription;
        // for(int i =0;i<_upright;i++){

        // }
        upright = _upright;
        reversed = _reversed;
    }

    // public BigAkanaCard(){

    // }
}
