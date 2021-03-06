//  Copyright 2019 Florian Gather <florian.gather@tngtech.com>
// 	Copyright 2019 Paula Ruiz <paularuiz22@gmail.com>
// 	Copyright 2019 Fritz Brandhuber <fritz.brandhuber@tngtech.com>
// 
// 	SPDX-License-Identifier: Apache-2.0

using Equ;

namespace ArchUnitNET.Domain.Dependencies.Types
{
    public class ImplementsInterfaceDependency : MemberwiseEquatable<ImplementsInterfaceDependency>, ITypeDependency
    {
        public ImplementsInterfaceDependency(IType origin, IType target)
        {
            Origin = origin;
            Target = target;
        }

        public IType Origin { get; }
        public IType Target { get; }
    }
}