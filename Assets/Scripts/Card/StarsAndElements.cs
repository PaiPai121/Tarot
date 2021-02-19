public enum Star{
    Uranus,
    Mercury,
    Moon

}

public enum Element{
    Wind,
    Water
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
            default:
                return "";
        }
    }
}