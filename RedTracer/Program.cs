using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using RedTracer;

string path = @"D:\bango.png";
Console.WriteLine(path);
var tracer = new Tracer();
var canvas = new FileCanvas(50, 50, path);
tracer.Init(canvas);
tracer.Draw();
tracer.Dispose();

Console.WriteLine("Finish");