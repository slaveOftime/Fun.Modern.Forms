﻿open Modern.Forms
open Fun.SunUI.Generator
open Utils


let controlCtx = {
    GeneratorContext.RootType = typeof<Control>
    BuilderName = "ModernFormsControlBuilder"
    UIStackName = "ModernForms"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun prop -> prop.PropertyType.IsAssignableTo typeof<Control.ControlCollection> && prop.Name = "Controls"
    ExcludeBaseTypes = []
}

let dir = @"C:\Users\woo\Documents\Code\Slaveoftime\Fun.Modern.Forms\Fun.SunUI.ModernForms"
let namesp = "Fun.SunUI.ModernForms"
let assemblyName = "Modern.Forms"

Generator.createCodeFile controlCtx dir namesp assemblyName "Controls.Generated"


let windowBaseCtx = {
    GeneratorContext.RootType = typeof<WindowBase>
    BuilderName = "ModernFormsWindowBaseBuilder"
    UIStackName = "ModernForms"
    ChildrenPropName = "Controls"
    IsChildrenProp = fun prop -> prop.PropertyType.IsAssignableTo typeof<Control.ControlCollection> && prop.Name = "Controls"
    ExcludeBaseTypes = []
}

Generator.createCodeFile windowBaseCtx dir namesp assemblyName "Windows.Generated"
