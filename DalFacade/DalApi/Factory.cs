namespace DalApi;
using static DalApi.DalConfig;
using System.Reflection;

public static class Factory
{

    //נזכיר שמטרת תבנית העיצוב Simple Factory
    //היא לאפשר לשכבה עליונה לייצר אובייקטים משכבה תחתונה אשר מממשים ממשק מוסכם,
    //מבלי להכיר את המחלקה המממשת .השכבה התחתונה תגדיר "מפעל לייצור אובייקטים"
    //(Factory), והייצור יעשה דרך מתודה (Get) שתחזיר עצם מאותחל מטיפוס הממשק.


    //●	נגדיר מחלקה בשם Factory
    //שתיעזר במחלקת Config
    //כדי לטעון ולאתחל את המחלקה הנכונה שאיתה נרצה לעבוד
    public static IDal Get
    {



        get
        {
            string dalType = s_dalName ?? throw new DalConfigException($"DAL name is not extracted from the configuration");
            string dal = s_dalPackages[dalType] ?? throw new DalConfigException($"Package for {dalType} is not found in packages list in dal-config.xml");

            try { Assembly.Load(dal ?? throw new DalConfigException($"Package {dal} is null")); }
            catch (Exception ex) { throw new DalConfigException($"Failed to load {dal}.dll package", ex); }

            Type type = Type.GetType($"Dal.{dal}, {dal}") ??
                throw new DalConfigException($"Class Dal.{dal} was not found in {dal}.dll");

            return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as IDal ??
                throw new DalConfigException($"Class {dal} is not a singleton or wrong property name for Instance");
        }
    }
}
