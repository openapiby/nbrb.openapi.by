Open FinTech API

## ABOUT

The Open FinTech API is a set of open interfaces for nodes in FinTech ecosystem:

1. Application developers may target and test interfaces with real data until banks and other endpoints prepare 
2. Endpoint providers may see which applications are welcome for their clients and direct funding towards implementing this API
3. Blockchain services may provide alternative platforms for existing interfaces

We use REST protocol with OpenAPI Specifications and custom autodiscovery through path convention and.

The project developed for 4th FinTech Hackaton in Minsk (#FTH17), where for another consequitive year no API were provided for application developers from banks, except for some beta API from Visa (which still came without required info about ATMs).

The motto of this hackaton was "Building FinTech Ecosystem in Belarus".

##  THE KEY POINTS

Instead of solid API like PSD2 and OpenBank API, which are hard to get complete, we separate API into lightweight interfaces. Interface is a small set of a few REST calls that is targeted to solve specific, logic centric problem. If you're familiar with interfaces in Go, this is much an extension to Open Web.

Autodiscovery allows bots, apps and djinni operate on API without user, or using user only for acquiring authorization an tokens to proceed.
