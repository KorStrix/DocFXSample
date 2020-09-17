# DocFX_ForUnityProject

이 프로젝트는 Unity Project를 GitHub Action(CI)를 통해 자동 생성하는 샘플 프로젝트입니다.

https://github.com/NormandErwan/DocFxForUnity
를 참고했습니다.

## GitHub Action

이 프로젝트의 액션 워크플로 코드 [링크](https://github.com/KorStrix/DocFXSample/blob/master/.github/workflows/Build_and_Deploy_DocFX.yml)

이 프로젝트의 액션 결과 [링크](https://github.com/KorStrix/DocFXSample/actions)

## 간단한 실행 방법

이 프로젝트를 다운 받은 뒤, `CMD`에서(PowerShell, Git Bash 안됨) `CD` 명령어를 통해 이 프로젝트 경로로 이동하고

`docfx ../UnitySample/Documentation/docfx.json --serve`

를 실행한 뒤,

웹 브라우저에서 `localhost:8080`로 들어가볼 것

## 아직 못한 것

Unity Cs Reference - Xref 빌드 및 링크 연결

### 도움이 된 링크
https://stewmcc.com/post/docfx-unity-gitlab/

https://light11.hatenadiary.com/entry/2020/05/08/213020
