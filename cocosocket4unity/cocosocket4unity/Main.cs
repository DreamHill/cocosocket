using System;
using LitJson;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using protocol;
using System.Reflection;
using System.IO;

namespace cocosocket4unity
{
	class MainClass
	{
		public static void Main0 (string[] args)
		{
            TestRequest request = new TestRequest();
            request.c = TestEnum.WHITE;
            MemoryStream stream = new MemoryStream();
            ProtoBuf.Serializer.NonGeneric.Serialize(stream, request);
            byte[] bs = stream.ToArray();
            Type type = typeof(TestRequest);
            Stream s = stream;
            request=  (TestRequest)ProtoBuf.Serializer.NonGeneric.Deserialize(type, s);
            Console.WriteLine(request);
            /**
            AuthRequest ar = new AuthRequest();
            string json = JsonMapper.ToJson(ar);
            Console.WriteLine(ar.GetType().Name+":"+json);
            List<Type> ls = ClassUtil.GetClasses("protocol");
            foreach (Type item in ls)
            {
              Console.WriteLine(item.Name);
              ConstructorInfo constructor = item.GetConstructor(new Type[0]);
              //ʹ�ù�������������������
              object obj = constructor.Invoke(new Object[0]);

              ProtoAttribute arr=  (ProtoAttribute)ClassUtil.GetAttribute(item,typeof(ProtoAttribute));
                if(arr!=null)
              Console.WriteLine(arr.value);
            }
            Console.Read();
            */
             /**
            long time_JAVA_Long = 1446050129676L;//java���������ڣ�����Ϊ��λ             
            DateTime dt_1970 = new DateTime(1970, 1, 1, 0, 0, 0);              
            long tricks_1970 = dt_1970.Ticks;//1970��1��1                 
            long time_tricks = tricks_1970 + time_JAVA_Long * 10000;//��־���ڿ̶�    
            DateTime dt = new DateTime(time_tricks).AddHours(8);//ת��ΪDateTime
            Console.WriteLine(string.Format("{0:G}", dt));
            Console.Read();
            */
            /**
			SocketListner listner = new TestListner ();
			USocket us = new USocket ();
			us.setLister (listner);
			Protocal p = new Varint32HeaderProtocol ();
            //Protocal p = new LVProtocal();
			us.setProtocal (p);
			us.Connect ("localhost", 4887);
			Console.Read();
             */
             
		}
	}
}
