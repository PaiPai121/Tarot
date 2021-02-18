public enum Star{
    Uranus,
    aaa

}

public enum Element{
    Wind
}

public static class CardInfoTransfer{
    public static string starTransfer(Star _star){
        switch(_star){
            case Star.Uranus:
                return "天王星"; 
                // break;
            default:
                return "";
        }
    }

    public static string elementTransfer(Element _element){
        switch(_element){
            case Element.Wind:
                return "风";
                // break;
            
            default:
                return "";
        }
    }
}