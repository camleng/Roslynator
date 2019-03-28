﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// <auto-generated>

using System;
using Microsoft.CodeAnalysis;

namespace Roslynator.CSharp
{
    public static partial class DiagnosticDescriptors
    {
        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor SimplifyLambdaExpressionParameterList = Create(
            id:                 DiagnosticIdentifiers.SimplifyLambdaExpressionParameterList, 
            title:              "Simplify lambda expression parameter list.", 
            messageFormat:      "Simplify lambda expression parameter list.", 
            category:           DiagnosticCategories.Simplification, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.SimplifyLambdaExpressionParameterList, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        public static readonly DiagnosticDescriptor SimplifyLambdaExpressionParameterListFadeOut = SimplifyLambdaExpressionParameterList.CreateFadeOut();

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor RemoveRedundantBraces = Create(
            id:                 DiagnosticIdentifiers.RemoveRedundantBraces, 
            title:              "Remove redundant braces.", 
            messageFormat:      "Remove redundant braces.", 
            category:           DiagnosticCategories.Redundancy, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveRedundantBraces, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        public static readonly DiagnosticDescriptor RemoveRedundantBracesFadeOut = RemoveRedundantBraces.CreateFadeOut();

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor ReplaceForEachWithFor = Create(
            id:                 DiagnosticIdentifiers.ReplaceForEachWithFor, 
            title:              "Replace foreach statement with for statement.", 
            messageFormat:      "Replace foreach statement with for statement.", 
            category:           DiagnosticCategories.General, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.ReplaceForEachWithFor, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        public static readonly DiagnosticDescriptor ReplaceForEachWithForFadeOut = ReplaceForEachWithFor.CreateFadeOut();

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor MergeLocalDeclarationWithReturnStatement = Create(
            id:                 DiagnosticIdentifiers.MergeLocalDeclarationWithReturnStatement, 
            title:              "Merge local declaration with return statement.", 
            messageFormat:      "Merge local declaration with return statement.", 
            category:           DiagnosticCategories.Simplification, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.MergeLocalDeclarationWithReturnStatement, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        public static readonly DiagnosticDescriptor MergeLocalDeclarationWithReturnStatementFadeOut = MergeLocalDeclarationWithReturnStatement.CreateFadeOut();

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor UseCountOrLengthPropertyInsteadOfCountMethod = Create(
            id:                 DiagnosticIdentifiers.UseCountOrLengthPropertyInsteadOfCountMethod, 
            title:              "Use 'Count/Length' property instead of 'Count' method.", 
            messageFormat:      "Use '{0}' property instead of 'Count' method.", 
            category:           DiagnosticCategories.Performance, 
            defaultSeverity:    DiagnosticSeverity.Warning, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.UseCountOrLengthPropertyInsteadOfCountMethod, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor CallAnyInsteadOfCount = Create(
            id:                 DiagnosticIdentifiers.CallAnyInsteadOfCount, 
            title:              "Call 'Enumerable.Any' instead of 'Enumerable.Count'.", 
            messageFormat:      "Call 'Enumerable.Any' instead of 'Enumerable.Count'.", 
            category:           DiagnosticCategories.Performance, 
            defaultSeverity:    DiagnosticSeverity.Warning, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.CallAnyInsteadOfCount, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor UseCSharp6DictionaryInitializer = Create(
            id:                 DiagnosticIdentifiers.UseCSharp6DictionaryInitializer, 
            title:              "Use C# 6.0 dictionary initializer.", 
            messageFormat:      "Use C# 6.0 dictionary initializer.", 
            category:           DiagnosticCategories.Usage, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.UseCSharp6DictionaryInitializer, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor CallCastInsteadOfSelect = Create(
            id:                 DiagnosticIdentifiers.CallCastInsteadOfSelect, 
            title:              "Call 'Enumerable.Cast' instead of 'Enumerable.Select'.", 
            messageFormat:      "Call 'Enumerable.Cast' instead of 'Enumerable.Select'.", 
            category:           DiagnosticCategories.Simplification, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.CallCastInsteadOfSelect, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor ReplaceReturnStatementWithExpressionStatement = Create(
            id:                 DiagnosticIdentifiers.ReplaceReturnStatementWithExpressionStatement, 
            title:              "Replace yield/return statement with expression statement.", 
            messageFormat:      "Replace {0} statement with expression statement.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.ReplaceReturnStatementWithExpressionStatement, 
            customTags:         WellKnownDiagnosticTags.Unnecessary);

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor AddBreakStatementToSwitchSection = Create(
            id:                 DiagnosticIdentifiers.AddBreakStatementToSwitchSection, 
            title:              "Add break statement to switch section.", 
            messageFormat:      "Add break statement to switch section.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddBreakStatementToSwitchSection, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor AddReturnStatementThatReturnsDefaultValue = Create(
            id:                 DiagnosticIdentifiers.AddReturnStatementThatReturnsDefaultValue, 
            title:              "Add return statement that returns default value.", 
            messageFormat:      "Add return statement that returns default value.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddReturnStatementThatReturnsDefaultValue, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor CallFindInsteadOfFirstOrDefault = Create(
            id:                 DiagnosticIdentifiers.CallFindInsteadOfFirstOrDefault, 
            title:              "Call 'Find' instead of 'FirstOrDefault'.", 
            messageFormat:      "Call 'Find' instead of 'FirstOrDefault'.", 
            category:           DiagnosticCategories.Performance, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.CallFindInsteadOfFirstOrDefault, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor UseElementAccessInsteadOfElementAt = Create(
            id:                 DiagnosticIdentifiers.UseElementAccessInsteadOfElementAt, 
            title:              "Use [] instead of calling 'ElementAt'.", 
            messageFormat:      "Use [] instead of calling 'ElementAt'.", 
            category:           DiagnosticCategories.Performance, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.UseElementAccessInsteadOfElementAt, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor UseElementAccessInsteadOfFirst = Create(
            id:                 DiagnosticIdentifiers.UseElementAccessInsteadOfFirst, 
            title:              "Use [] instead of calling 'First'.", 
            messageFormat:      "Use [] instead of calling 'First'.", 
            category:           DiagnosticCategories.Performance, 
            defaultSeverity:    DiagnosticSeverity.Info, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.UseElementAccessInsteadOfFirst, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor AddMissingSemicolon = Create(
            id:                 DiagnosticIdentifiers.AddMissingSemicolon, 
            title:              "Add missing semicolon.", 
            messageFormat:      "Add missing semicolon.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: false, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddMissingSemicolon, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor MarkMemberAsStatic = Create(
            id:                 DiagnosticIdentifiers.MarkMemberAsStatic, 
            title:              "Mark member as static.", 
            messageFormat:      "Mark member as static.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.MarkMemberAsStatic, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor ReplaceReturnWithYieldReturn = Create(
            id:                 DiagnosticIdentifiers.ReplaceReturnWithYieldReturn, 
            title:              "Replace return with yield return.", 
            messageFormat:      "Replace return with yield return.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.ReplaceReturnWithYieldReturn, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor AddDocumentationComment = Create(
            id:                 DiagnosticIdentifiers.AddDocumentationComment, 
            title:              "Add documentation comment to publicly visible type or member.", 
            messageFormat:      "Add documentation comment to publicly visible type or member.", 
            category:           DiagnosticCategories.Maintainability, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.AddDocumentationComment, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor MarkContainingClassAsAbstract = Create(
            id:                 DiagnosticIdentifiers.MarkContainingClassAsAbstract, 
            title:              "Mark containing class as abstract.", 
            messageFormat:      "Mark containing class as abstract.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.MarkContainingClassAsAbstract, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor RemoveInapplicableModifier = Create(
            id:                 DiagnosticIdentifiers.RemoveInapplicableModifier, 
            title:              "Remove inapplicable modifier.", 
            messageFormat:      "Remove inapplicable modifier.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveInapplicableModifier, 
            customTags:         WellKnownDiagnosticTags.Unnecessary);

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor RemoveUnreachableCode = Create(
            id:                 DiagnosticIdentifiers.RemoveUnreachableCode, 
            title:              "Remove unreachable code.", 
            messageFormat:      "Remove unreachable code.", 
            category:           DiagnosticCategories.General, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveUnreachableCode, 
            customTags:         WellKnownDiagnosticTags.Unnecessary);

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor RemoveImplementationFromAbstractMember = Create(
            id:                 DiagnosticIdentifiers.RemoveImplementationFromAbstractMember, 
            title:              "Remove implementation from abstract member.", 
            messageFormat:      "Remove implementation from {0}.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.RemoveImplementationFromAbstractMember, 
            customTags:         WellKnownDiagnosticTags.Unnecessary);

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor MemberTypeMustMatchOverriddenMemberType = Create(
            id:                 DiagnosticIdentifiers.MemberTypeMustMatchOverriddenMemberType, 
            title:              "Member type must match overriden member type.", 
            messageFormat:      "Member type must match overriden member type.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.MemberTypeMustMatchOverriddenMemberType, 
            customTags:         Array.Empty<string>());

        [Obsolete("", error: true)]
        internal static readonly DiagnosticDescriptor OverridingMemberCannotChangeAccessModifiers = Create(
            id:                 DiagnosticIdentifiers.OverridingMemberCannotChangeAccessModifiers, 
            title:              "Overriding member cannot change access modifiers.", 
            messageFormat:      "Overriding member cannot change access modifiers.", 
            category:           DiagnosticCategories.ErrorFix, 
            defaultSeverity:    DiagnosticSeverity.Hidden, 
            isEnabledByDefault: true, 
            description:        null, 
            helpLinkUri:        DiagnosticIdentifiers.OverridingMemberCannotChangeAccessModifiers, 
            customTags:         Array.Empty<string>());

    }
}