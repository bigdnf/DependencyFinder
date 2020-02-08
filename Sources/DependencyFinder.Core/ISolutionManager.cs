﻿using DependencyFinder.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DependencyFinder.Core
{
    public interface ISolutionManager : IDisposable
    {
        IAsyncEnumerable<Reference> FindAllReferences(string rootPath, string sourceProject, string className);

        IAsyncEnumerable<string> FindSolutions(string rootDirectory);

        IAsyncEnumerable<string> FindSolutionWithProject(string rootDirectory, string projectName);

        Task<IEnumerable<ProjectDetails>> OpenSolution(string solutionPath);
        Task<IEnumerable<TypeDetails>> GetProjectTypes(string projectPath, string solutionPath);
    }
}