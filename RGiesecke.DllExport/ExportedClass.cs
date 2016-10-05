﻿// [Decompiled] Assembly: RGiesecke.DllExport, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// Author of original assembly (MIT-License): Robert Giesecke
// Use Readme & LICENSE files for details.

using System;
using System.Collections.Generic;

namespace RGiesecke.DllExport
{
    using EMIndex = Dictionary<string, int>;

    public class ExportedClass
    {
        private readonly List<ExportedMethod> _Methods = new List<ExportedMethod>();
        private readonly Dictionary<string, List<ExportedMethod>> _MethodsByName = new Dictionary<string, List<ExportedMethod>>();

        private EMIndex emOrder = new EMIndex();

        public string FullTypeName
        {
            get;
            private set;
        }

        public bool HasGenericContext
        {
            get;
            private set;
        }

        internal Dictionary<string, List<ExportedMethod>> MethodsByName
        {
            get {
                return this._MethodsByName;
            }
        }

        internal List<ExportedMethod> Methods
        {
            get {
                return this._Methods;
            }
        }

        public ExportedClass(string fullTypeName, bool hasGenericContext)
        {
            this.FullTypeName = fullTypeName;
            this.HasGenericContext = hasGenericContext;
        }

        internal void Refresh()
        {
            lock(this)
            {
                this.MethodsByName.Clear();
                foreach(ExportedMethod item_0 in this.Methods)
                {
                    List<ExportedMethod> local_1;
                    if(!this.MethodsByName.TryGetValue(item_0.Name, out local_1))
                    {
                        this.MethodsByName.Add(item_0.Name, local_1 = new List<ExportedMethod>());
                    }
                    local_1.Add(item_0);
                }
            }
        }

        /// <summary>
        /// 
        /// TODO: To get from zero index - it was in original code, as getting of first exported method.
        ///       However, to solve problem https://github.com/3F/DllExport/issues/10 I also added the `ExportName` instead of `MemberName` in AssemblyExports.cs
        ///       And I left it 'as is', but the good way to provide information about arguments, i.e.:
        ///       ~ 'Print'(int32 'a') cil managed   -> .export [0] as 'Print1'
        ///       ~ 'Print'(bool 'b') cil managed    -> .export [1] as 'Print2'
        ///       
        /// this also affects on DllExportWeaver.RunIlAsm
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal ExportedMethod nextExportedMethod(string name)
        {
            if(String.IsNullOrWhiteSpace(name)) {
                throw new ArgumentException("The name cannot be null or empty for EMIndex.");
            }

            if(!emOrder.ContainsKey(name)) {
                emOrder[name] = 0;
            }
            return MethodsByName[name][emOrder[name]++]; // moving in order by adding
        }

        internal void resetExportedMethods()
        {
            if(emOrder == null) {
                emOrder = new EMIndex();
                return;
            }
            emOrder.Clear();
        }
    }
}
