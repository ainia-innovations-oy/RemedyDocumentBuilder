using DocumentBuilderNet;

string path = Environment.GetCommandLineArgs()[1];
string outFile = Environment.GetCommandLineArgs()[2];

RecData.CreatePDFFIle(path, outFile);