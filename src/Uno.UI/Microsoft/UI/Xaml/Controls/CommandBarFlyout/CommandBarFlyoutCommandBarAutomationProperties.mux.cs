﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// MUX Reference controls\dev\CommandBarFlyout\CommandBarFlyoutCommandBarAutomationProperties.cpp, tag winui3/release/1.5.2, commit b91b3ce6f25c587a9e18c4e122f348f51331f18b

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Automation;
using Microsoft.UI.Xaml.Automation.Peers;

namespace Microsoft.UI.Xaml.Controls.Primitives;

partial class CommandBarFlyoutCommandBarAutomationProperties
{
	// Forward changes to CommandBarFlyoutCommandBarAutomationProperties.ControlType on to
	// AutomationProperties.ControlType.  We need to do this indirection since we can't
	// access types in XAML that we're interacting with via a known interface GUID.
	private static void OnControlTypePropertyChanged(
		DependencyObject sender,
		DependencyPropertyChangedEventArgs args)
	{
		if (sender is UIElement senderAsUIE)
		{
			AutomationProperties.SetAutomationControlType(
				senderAsUIE,
				(AutomationControlType)args.NewValue);
		}
	}
}