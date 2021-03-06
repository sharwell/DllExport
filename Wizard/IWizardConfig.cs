﻿/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2016-2020  Denis Kuzmin < x-3F@outlook.com > GitHub/3F
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
*/

namespace net.r_eg.DllExport.Wizard
{
    public interface IWizardConfig
    {
        /// <summary>
        /// Path to directory with .sln files to be processed.
        /// </summary>
        string SlnDir { get; }

        /// <summary>
        /// Optional predefined .sln file to process via the restore operations etc.
        /// </summary>
        string SlnFile { get; }

        /// <summary>
        /// Root path of the DllExport package.
        /// </summary>
        string PkgPath { get; }

        /// <summary>
        /// Relative path from PkgPath to DllExport meta library.
        /// </summary>
        string MetaLib { get; }

        /// <summary>
        /// Path to .targets file of the DllExport.
        /// </summary>
        string DxpTarget { get; }

        /// <summary>
        /// Arguments to manager.
        /// </summary>
        string MgrArgs { get; }

        /// <summary>
        /// Path to external storage if used.
        /// </summary>
        string StoragePath { get; }

        /// <summary>
        /// Where to store configuration data.
        /// </summary>
        CfgStorageType CfgStorage { get; set; }

        /// <summary>
        /// The evaluated type of operation.
        /// </summary>
        ActionType Type { get; }
    }
}
