# Cadmus Sidon API

Quick Docker image build:

    docker build . -t vedph2020/cadmus-sidon-api:2.0.0 -t vedph2020/cadmus-sidon-api:latest

(replace with the current version).

This is a Cadmus API layer customized for the PRJ project. Most of its code is derived from shared Cadmus libraries. See the [documentation](https://github.com/vedph/cadmus_doc/blob/master/guide/api.md) for more.

## History

# 2.0.0

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
