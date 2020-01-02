<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /readme.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# <img src="/src/icon.png" height="30px"> NServiceBus.HandlerOrdering

[![Build status](https://ci.appveyor.com/api/projects/status/l2jg521r03ei7a3n/branch/master?svg=true)](https://ci.appveyor.com/project/SimonCropp/nservicebus-HandlerOrdering)
[![NuGet Status](https://img.shields.io/nuget/v/NServiceBus.HandlerOrdering.svg)](https://www.nuget.org/packages/NServiceBus.HandlerOrdering/)

This extension allows a more expressive way to [order handlers](https://docs.particular.net/nservicebus/handlers/handler-ordering). HandlerOrdering allows the dependency between handlers to be expressed via interfaces and the resulting order is derived at runtime.

<!-- toc -->
## Contents

  * [Community backed](#community-backed)
    * [Sponsors](#sponsors)
    * [Patrons](#patrons)
  * [Usage](#usage)
  * [Expressing dependencies](#expressing-dependencies)
    * [Resulting execution order](#resulting-execution-order)
  * [Sample](#sample)
    * [Configuring to use HandlerOrdering](#configuring-to-use-handlerordering)
    * [Expressing dependencies](#expressing-dependencies-1)
    * [Resulting execution order](#resulting-execution-order-1)<!-- endtoc -->

<!--- StartOpenCollectiveBackers -->

[Already a Patron? skip past this section](#endofbacking)


## Community backed

**It is expected that all developers [become a Patron](https://opencollective.com/nservicebusextensions/order/6976) to use this tool. [Go to licensing FAQ](https://github.com/NServiceBusExtensions/Home/#licensingpatron-faq)**

Thanks to the current backers.

<img src="https://opencollective.com/nservicebusextensions/tiers/patron.svg?width=890&avatarHeight=60&button=false">

<a href="#" id="endofbacking"></a>

<!--- EndOpenCollectiveBackers -->


## NuGet package

https://nuget.org/packages/NServiceBus.HandlerOrdering/


## Usage

<!-- snippet: Usage -->
<a id='snippet-usage'/></a>
```cs
configuration.ApplyInterfaceHandlerOrdering();
```
<sup><a href='/src/Tests/Snippets/Usage.cs#L8-L12' title='File snippet `usage` was extracted from'>snippet source</a> | <a href='#snippet-usage' title='Navigate to start of snippet `usage`'>anchor</a></sup>
<!-- endsnippet -->


## Expressing dependencies


#### MessageHandler1 wants to run after MessageHandler3

<!-- snippet: express-order1 -->
<a id='snippet-express-order1'/></a>
```cs
public class MessageHandler1 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler3>
{
```
<sup><a href='/src/Sample/MessageHandler1.cs#L7-L12' title='File snippet `express-order1` was extracted from'>snippet source</a> | <a href='#snippet-express-order1' title='Navigate to start of snippet `express-order1`'>anchor</a></sup>
<a id='snippet-express-order1-1'/></a>
```cs
public class MessageHandler1 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler3>
{
```
<sup><a href='/src/Tests/Snippets/MessageHandler1.cs#L5-L10' title='File snippet `express-order1` was extracted from'>snippet source</a> | <a href='#snippet-express-order1-1' title='Navigate to start of snippet `express-order1`'>anchor</a></sup>
<!-- endsnippet -->


#### MessageHandler2 wants to run after MessageHandler1

<!-- snippet: express-order2 -->
<a id='snippet-express-order2'/></a>
```cs
public class MessageHandler2 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler1>
{
```
<sup><a href='/src/Sample/MessageHandler2.cs#L8-L13' title='File snippet `express-order2` was extracted from'>snippet source</a> | <a href='#snippet-express-order2' title='Navigate to start of snippet `express-order2`'>anchor</a></sup>
<a id='snippet-express-order2-1'/></a>
```cs
public class MessageHandler2 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler1>
{
```
<sup><a href='/src/Tests/Snippets/MessageHandler2.cs#L5-L10' title='File snippet `express-order2` was extracted from'>snippet source</a> | <a href='#snippet-express-order2-1' title='Navigate to start of snippet `express-order2`'>anchor</a></sup>
<!-- endsnippet -->


### Resulting execution order

 1. MessageHandler3
 1. MessageHandler1
 1. MessageHandler2


## Sample

[The sample](/src/Sample) demonstrates how to use interfaces to express dependencies between handlers.


### Configuring to use HandlerOrdering

<!-- snippet: config -->
<a id='snippet-config'/></a>
```cs
endpointConfiguration.ApplyInterfaceHandlerOrdering();
```
<sup><a href='/src/Sample/Program.cs#L14-L16' title='File snippet `config` was extracted from'>snippet source</a> | <a href='#snippet-config' title='Navigate to start of snippet `config`'>anchor</a></sup>
<!-- endsnippet -->


### Expressing dependencies


#### MessageHandler1 wants to run after MessageHandler3

<!-- snippet: express-order1 -->
<a id='snippet-express-order1'/></a>
```cs
public class MessageHandler1 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler3>
{
```
<sup><a href='/src/Sample/MessageHandler1.cs#L7-L12' title='File snippet `express-order1` was extracted from'>snippet source</a> | <a href='#snippet-express-order1' title='Navigate to start of snippet `express-order1`'>anchor</a></sup>
<a id='snippet-express-order1-1'/></a>
```cs
public class MessageHandler1 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler3>
{
```
<sup><a href='/src/Tests/Snippets/MessageHandler1.cs#L5-L10' title='File snippet `express-order1` was extracted from'>snippet source</a> | <a href='#snippet-express-order1-1' title='Navigate to start of snippet `express-order1`'>anchor</a></sup>
<!-- endsnippet -->


#### MessageHandler2 wants to run after MessageHandler1

<!-- snippet: express-order2 -->
<a id='snippet-express-order2'/></a>
```cs
public class MessageHandler2 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler1>
{
```
<sup><a href='/src/Sample/MessageHandler2.cs#L8-L13' title='File snippet `express-order2` was extracted from'>snippet source</a> | <a href='#snippet-express-order2' title='Navigate to start of snippet `express-order2`'>anchor</a></sup>
<a id='snippet-express-order2-1'/></a>
```cs
public class MessageHandler2 :
    IHandleMessages<MyMessage>,
    IWantToRunAfter<MessageHandler1>
{
```
<sup><a href='/src/Tests/Snippets/MessageHandler2.cs#L5-L10' title='File snippet `express-order2` was extracted from'>snippet source</a> | <a href='#snippet-express-order2-1' title='Navigate to start of snippet `express-order2`'>anchor</a></sup>
<!-- endsnippet -->


### Resulting execution order

 1. MessageHandler3
 1. MessageHandler1
 1. MessageHandler2


## Release Notes

See [closed milestones](../../milestones?state=closed).


## Icon

Icon courtesy of [The Noun Project](https://thenounproject.com)
