public enum Star{
    Uranus,
    Mercury,
    Moon,
    Venus,
    Aries,
    Taurus,
    Gemini,
    Cancer,
    Leo,
    Virgo,
    Jupiter

}

public enum Element{
    Wind,
    Water,
    Earth,
    Air,
    Fire
}

public static class CardInfoTransfer{
    public static string starTransfer(Star _star){
        switch(_star){
            case Star.Uranus:
                return "天王星"; 
                // break;
            case Star.Mercury:
                return "水星";
            case Star.Moon:
                return "月亮";
            case Star.Venus:
                return "金星";
            case Star.Aries:
                return "牧羊座";
            case Star.Taurus:
                return "金牛座";
            case Star.Gemini:
                return "双子座";
            case Star.Cancer:
                return "巨蟹座";
            case Star.Leo:
                return "狮子座";
            case Star.Virgo:
                return "处女座";
            case Star.Jupiter:
                return "木星";
            default:
                return "";
        }
    }

    public static string elementTransfer(Element _element){
        switch(_element){
            case Element.Wind:
                return "风";
                // break;
            case Element.Water:
                return "水";
            case Element.Earth:
                return "土";
            case Element.Air:
                return "气";
            case Element.Fire:
                return "火";
            default:
                return "";
        }
    }
}