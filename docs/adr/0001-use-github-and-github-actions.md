# ADR-0001: Use GitHub and GitHub Actions for source control and CI

## Status
Accepted

---

## Context

The HelixCare platform requires a source control and continuous integration (CI) system that supports:

- collaboration (even if currently solo development)
- automation of builds and validation
- future scalability to multiple services and teams
- integration with modern cloud-native workflows

The organisation has mixed tooling in use (Azure Repos, GitHub, and others), but is increasingly adopting GitHub Enterprise.

We need to make a clear platform-level decision for this repository to avoid fragmentation.

---

## Decision

We will use:

- GitHub as the source control platform
- GitHub Actions as the CI pipeline system

for the HelixCare platform repository.

---

## Rationale

GitHub and GitHub Actions were selected because:

- Tight integration between source control and CI
- Industry standard for modern open-source and enterprise development
- Strong ecosystem support for .NET and cloud-native applications
- Simple and fast setup for CI pipelines
- Alignment with future goal of making HelixCare components open-source where appropriate

---

## Consequences

### Positive

- Consistent CI/CD pipeline across the platform
- Easier onboarding for future contributors
- Native integration with pull requests and branch workflows
- Reduced operational overhead compared to separate CI systems

### Negative

- Divergence from some existing organisational Azure Repos usage
- Requires discipline to maintain GitHub-based workflows consistently

---

## Notes

This decision applies only to the HelixCare platform repository and does not mandate organisation-wide tooling changes.

Future ADRs may refine CI/CD processes or introduce additional tooling (e.g. deployment pipelines, environment promotion strategies).