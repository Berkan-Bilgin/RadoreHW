// See https://aka.ms/new-console-template for more information
using Logger_bad_;

Console.WriteLine("Hello, World!");
//TODO: json log ekle

//Yeni bir log sistemini Logger classını hic bir sekilde degistirmeden yeni bir log formatını sisteme ekle.

XmlLog xmlLog = new XmlLog();
DbLog dbLog = new DbLog();
JsonLog jsonLog = new JsonLog();

Logger logger = new Logger(dbLog, xmlLog, jsonLog);

logger.LogKaydet(LogType.Xml, " 303 nolo hata kodu olustu");

logger.LogKaydet(LogType.Db, " 305 nolo hata kodu olustu");

logger.LogKaydet(LogType.Json, " 305 nolo hata kodu olustu");



