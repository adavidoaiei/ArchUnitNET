/*
 * Copyright 2019 TNG Technology Consulting GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using ArchUnitNET.Domain;
using JetBrains.Annotations;
using Mono.Cecil;

namespace ArchUnitNET.Core
{
    internal class TypeRegistry
    {
        private readonly Dictionary<string, IType> _allTypes = new Dictionary<string, IType>();

        public IType GetOrCreateTypeFromTypeReference([NotNull] TypeReference typeReference, [NotNull] Func<string, IType> createFunc)
        {
            return RegistryUtils.GetFromDictOrCreateAndAdd(typeReference.FullName, _allTypes,
                createFunc);
        }
    }
}