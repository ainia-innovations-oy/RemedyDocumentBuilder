/*
 * Creates a console application for PDF Generation that accepts 2 parameters: <Template Path, Output Path>  
 * 
 * Copyright (C) 2023 Ainia Solutions Oy
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using DocumentBuilderNet;

string path = Environment.GetCommandLineArgs()[1];
string outFile = Environment.GetCommandLineArgs()[2];

FileGeneration.CreatePDFFIle(path, outFile);