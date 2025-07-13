

namespace DO;
[Serializable]
public class DalIdNotExistsException : Exception
{
	public DalIdNotExistsException(string massage) : base(massage) { }
    public DalIdNotExistsException(string massage,Exception innerException) : base(massage,innerException) { }
}
[Serializable]
public class DalIdExistsException : Exception
{
    public DalIdExistsException(string massage) : base(massage) { }
    public DalIdExistsException(string massage, Exception innerException) : base(massage, innerException) { }
}


