using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
 
using System;
 
 
 
public class MovingParticles : MonoBehaviour
{
    private MqttClient client;
    public GameObject[] Spheres = new GameObject[17];
    private string value;
    float x0=0, x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0, x8 = 0, x9 = 0, x10 = 0, x11 = 0, x12 = 0, x13 = 0, x14 = 0, x15 = 0, x16 = 0;
    float y0 = 0, y1 = 0, y2 = 0, y3 = 0, y4 = 0, y5 = 0, y6 = 0, y7 = 0, y8 = 0, y9 = 0, y10 = 0, y11 = 0, y12 = 0, y13 = 0, y14 = 0, y15 = 0, y16 = 0;
    float z0 = 0, z1 = 0, z2 = 0, z3 = 0, z4 = 0, z5 = 0, z6 = 0, z7 = 0, z8 = 0, z9 = 0, z10 = 0, z11 = 0, z12 = 0, z13 = 0, z14 = 0, z15 = 0, z16 = 0;
    Vector3[] position;
  
    // Use this for initialization
    void Start()
    {
        // create client instance 
        client = new MqttClient(IPAddress.Parse("172.16.145.251"), 1883, false, null);
 
        // register to message received 
        client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
 
        string clientId = Guid.NewGuid().ToString();
        client.Connect(clientId);
 
        // subscribe to the topic "/home/temperature" with QoS 2 
        client.Subscribe(new string[] { "hello/world" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        
 
 
    }
    void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
    {
        
        value = System.Text.Encoding.UTF8.GetString(e.Message);
        Debug.Log(value);
        string[] lines = value.Split(new[] { "/n" }, StringSplitOptions.None);        
        x0 = float.Parse(lines[0]) / 100;
        y0 = float.Parse(lines[1]) / 100;
        z0 = float.Parse(lines[2]) / 100;
        x1 = float.Parse(lines[3]) / 100;
        y1 = float.Parse(lines[4]) / 100;
        z1 = float.Parse(lines[5]) / 100;
        x2 = float.Parse(lines[6]) / 100;
        y2 = float.Parse(lines[7]) / 100;
        z2 = float.Parse(lines[8]) / 100;
        x3 = float.Parse(lines[9]) / 100;
        y3 = float.Parse(lines[10]) / 100;
        z3 = float.Parse(lines[11]) / 100;
        x4 = float.Parse(lines[12]) / 100;
        y4 = float.Parse(lines[13]) / 100;
        z4 = float.Parse(lines[14]) / 100;
        x5 = float.Parse(lines[15]) / 100;
        y5 = float.Parse(lines[16]) / 100;
        z5 = float.Parse(lines[17]) / 100;
        x6 = float.Parse(lines[18]) / 100;
        y6 = float.Parse(lines[19]) / 100;
        z6 = float.Parse(lines[20]) / 100;
        x7 = float.Parse(lines[21]) / 100;
        y7 = float.Parse(lines[22]) / 100;
        z7 = float.Parse(lines[23]) / 100;
        x8 = float.Parse(lines[24]) / 100;
        y8 = float.Parse(lines[25]) / 100;
        z8 = float.Parse(lines[26]) / 100;
        x9 = float.Parse(lines[27]) / 100;
        y9 = float.Parse(lines[28]) / 100;
        z9 = float.Parse(lines[29]) / 100;
        x10 = float.Parse(lines[30]) / 100;
        y10 = float.Parse(lines[31]) / 100;
        z10 = float.Parse(lines[32]) / 100;
        x11 = float.Parse(lines[33]) / 100;
        y11 = float.Parse(lines[34]) / 100;
        z11 = float.Parse(lines[35]) / 100;
        x12 = float.Parse(lines[36]) / 100;
        y12 = float.Parse(lines[37]) / 100;
        z12 = float.Parse(lines[38]) / 100;
        x13 = float.Parse(lines[39]) / 100;
        y13 = float.Parse(lines[40]) / 100;
        z13 = float.Parse(lines[41]) / 100;
        x14 = float.Parse(lines[42]) / 100;
        y14 = float.Parse(lines[43]) / 100;
        z14 = float.Parse(lines[44]) / 100;
        x15 = float.Parse(lines[45]) / 100;
        y15 = float.Parse(lines[46]) / 100;
        z15 = float.Parse(lines[47]) / 100;
        x16 = float.Parse(lines[48]) / 100;
        y16 = float.Parse(lines[49]) / 100;
        z16 = float.Parse(lines[50]) / 100;
    }
 
  
    // Update is called once per frame
    void Update()
    {
        Spheres[0].transform.position = new Vector3 (x0,y0,z0);
        Spheres[1].transform.position = new Vector3(x1, y1, z1);
        Spheres[2].transform.position = new Vector3(x2, y2, z2);
        Spheres[3].transform.position = new Vector3(x3, y3, z3);
        Spheres[4].transform.position = new Vector3(x4, y4, z4);
        Spheres[5].transform.position = new Vector3(x5, y5, z5);
        Spheres[6].transform.position = new Vector3(x6, y6, z6);
        Spheres[7].transform.position = new Vector3(x7, y7, z7);
        Spheres[8].transform.position = new Vector3(x8, y8, z8);
        Spheres[9].transform.position = new Vector3(x9, y9, z9);
        Spheres[10].transform.position = new Vector3(x10, y10, z10);
        Spheres[11].transform.position = new Vector3(x11, y11, z11);
        Spheres[12].transform.position = new Vector3(x12, y12, z12);
        Spheres[13].transform.position = new Vector3(x13, y13, z13);
        Spheres[14].transform.position = new Vector3(x14, y14, z14);
        Spheres[15].transform.position = new Vector3(x15, y15, z15);
        Spheres[16].transform.position = new Vector3(x16, y16, z16);
    }
}