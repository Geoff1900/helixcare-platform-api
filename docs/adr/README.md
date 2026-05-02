# Architecture Decision Records (ADR)

This folder contains Architecture Decision Records (ADRs) for the HelixCare platform.

ADRs are short, structured documents that capture important architectural decisions,
along with the context and reasoning behind them.

---

## Purpose

We use ADRs to:

- Record significant technical decisions
- Capture the reasoning behind choices
- Provide historical context for future developers
- Avoid repeated debate on already-made decisions

---

## Format

Each ADR should be a standalone Markdown file using the following pattern:

```0001-title-of-decision.md```

Example:

```0001-use-github-for-source-control.md```


---

## ADR Structure

Each ADR should include:

- Status (Proposed, Accepted, Superseded)
- Context (what problem are we solving?)
- Decision (what was chosen?)
- Consequences (what are the trade-offs?)

---

## Example ADR

See existing ADR files in this folder for examples.

---

## Notes

- ADRs are immutable once accepted (we don’t edit history, we add new decisions)
- New decisions that replace old ones should reference previous ADRs
- Keep ADRs short and focused

---

## Related

- System architecture: `/docs/architecture/`
- Engineering workflows: `/docs/workflows/`

