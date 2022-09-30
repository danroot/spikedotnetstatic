# Spike Dotnet Static Site Generator
This is a proof-of-concept for generating a static site for CloudFlare Pages (and possibly other static site hosts) using .NET.

A few things I learned with this project:

* How CloudFlare Pages works and that it is possible to run dotnet to generate your static site
* Markdig is a nice Markdown library
* The build environment is linux, so case-sensitive. File.ReadAllText("Index.md") != File.ReadAllText("Index.html")

Next up:

* Create a new project with more robust generator.  I'd like to have one or more IContentSource to get all content modified since last run, then IOutputGenerator to generate output.  I'd like one option to be able to generate output using Razor views or pages.
* Create a simple search that works with CloudFlare Functions.  Many static site starters use simple client-side search or else 3rd party like Angolia.  Client-side stinks because it pulls the entire index down to the client, which doesn't scale for large indexes.  I'd rather publish the index and a simple serverless function so that search can happen server-side.
* Evaluate existing dotnet static site generators (there aren't many!) to see how well they fit the features above.


