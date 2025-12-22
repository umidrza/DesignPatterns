# Adapter (Structural)

Adapter converts one interface into another that clients expect.
It allows incompatible interfaces to work together.

This example adapts a third-party email SDK to the application's
IEmailSender interface without changing domain code.

## Roles
- Target: IEmailSender (what the app expects)
- Adaptee: ThirdPartyMailer (external SDK)
- Adapter: ThirdPartyEmailSenderAdapter

## When to use
- Wrapping third-party or legacy APIs
- Replacing vendors without touching domain logic
- Isolating infrastructure details

## Key idea
Domain code depends only on IEmailSender.
All translation logic lives in the adapter.

