# Cadmus Sidon API

Quick Docker image build:

    docker build . -t vedph2020/cadmus-sidon-api:4.0.0 -t vedph2020/cadmus-sidon-api:latest

(replace with the current version).

This is a Cadmus API layer customized for the PRJ project. Most of its code is derived from shared Cadmus libraries. See the [documentation](https://github.com/vedph/cadmus_doc/blob/master/guide/api.md) for more.

## History

### 4.0.0

- 2023-07-02: [migrated to PostgreSQL](https://myrmex.github.io/overview/cadmus/dev/history/b-rdbms/).

### 3.0.0

- 2023-02-05: migrated to new components factory. This is a breaking change for backend components, please see [this page](https://myrmex.github.io/overview/cadmus/dev/history/#2023-02-01---backend-infrastructure-upgrade). Anyway, in the end you just have to update your libraries and a single namespace reference. Benefits include:
  - more streamlined component instantiation.
  - more functionality in components factory, including DI.
  - dropped third party dependencies.
  - adopted standard MS technologies for DI.

### 2.0.0

- 2022-12-17: updated packages.
- 2022-11-10: upgraded to NET 7.
- 2022-10-10: updated packages and injection in `Startup.cs` for new `IRepositoryProvider`.
- 2022-10-05:
  - updated Cadmus API packages.
  - added preview for apparatus and note.

### 1.0.4

- 2022-09-29: optional HTTPS redirection.

### 1.0.3

- 2022-09-28: updated packages.

### 1.0.2

- 2022-09-05: added orthography layer.
- 2022-08-18: added preview.
- 2022-07-15: updated packages.
- updated packages and added mss list to thesauri.

### 1.0.1

- first test release.
