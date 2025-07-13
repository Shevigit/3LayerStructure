

namespace BO;

[Serializable]
public class BlIdNotExistsException : Exception
{
    public BlIdNotExistsException(string massage) : base(massage) { }
    public BlIdNotExistsException(string massage, Exception innerException) : base(massage, innerException) { }
}
[Serializable]
public class BlIdExistsException : Exception
{
    public BlIdExistsException(string massage) : base(massage) { }
    public BlIdExistsException(string massage, Exception innerException) : base(massage, innerException) { }
}
//האם לכתוב את השגיאה הזו או את הבאה בתור???????????????
[Serializable]
public class BlInputNotCorectException : Exception
{
    public BlInputNotCorectException(string massage) : base(massage) { }
    public BlInputNotCorectException(string massage, Exception innerException) : base(massage, innerException) { }
}
////זה שגיאה שהמורה כתבה
//[Serializable]
//public class BlDoesNotExistException : Exception
//{
//    public BlDoesNotExistException(string? message) : base(message) { }
//    public BlDoesNotExistException(string message, Exception innerException)
//                : base(message, innerException) { }
//}








