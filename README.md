![Build and Deploy](https://github.com/KorStrix/DocFX_ForUnityProject/workflows/Build%20and%20Deploy/badge.svg?branch=master)

# 개요

이 프로젝트는 Unity Project를 GitHub Action(CI)를 통해 자동 생성하는 샘플 프로젝트입니다.

https://github.com/NormandErwan/DocFxForUnity
를 참고했습니다.

### 이 프로젝트의 DocFX 결과 사이트
https://korstrix.github.io/docfxsample/


## GitHub Action

이 프로젝트의 액션 워크플로 코드 [링크](https://github.com/KorStrix/DocFX_ForUnityProject/blob/master/.github/workflows/Build_and_DeployDocFX.yml)

이 프로젝트의 액션 결과 [링크](https://github.com/KorStrix/DocFX_ForUnityProject/actions)

## 간단한 실행 방법

이 프로젝트를 다운 받은 뒤, `CMD`에서(PowerShell, Git Bash 안됨) `CD` 명령어를 통해 이 프로젝트 경로로 이동하고

`docfx ../UnitySample/Documentation/docfx.json --serve`

를 실행한 뒤,

웹 브라우저에서 `localhost:8080`로 들어가볼 것


## 덧글기능(DISQUS)

https://github.com/KorStrix/DocFX_ForUnityProject/blob/26907465c3022c191bedff3daa954b2cb0827794/UnitySample/Documentation/templates/unity/layout/_master.tmpl#L45

여기에 DISQUS site를 연결해야 합니다.

# Diagram

Mermaid 다이어그램을 사용합니다.
https://github.com/mermaid-js/mermaid

## Unity Github Project에 DocFX 설치 방법

1. `Documentation` 폴더 및 내용물과 , `.github/workflows/Build_and_DeployDocFX.yml` 파일을 깃허브 유니티 프로젝트에 옮깁니다.

2. 옮긴 `Build_and_DeployDocFX.yml`을 수정합니다.

3. 옮긴 깃허브 프로젝트 세팅에 `ACCESS_TOKEN` Secret을 저장합니다.

4. 옮긴 깃허브 프로젝트의 gitignore에 *.csproj를 주석처리 합니다. (DocFX에서 필요합니다)

4. `push`를 해봅니다.

## 아직 못한 것

Unity Cs Reference - Xref 빌드 및 링크 연결


### 도움이 된 링크
https://stewmcc.com/post/docfx-unity-gitlab/

https://light11.hatenadiary.com/entry/2020/05/08/213020
