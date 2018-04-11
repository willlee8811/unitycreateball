pipeline {
  agent any
  stages {
    stage('stage1') {
      parallel {
        stage('stage1-2') {
          steps {
            echo '1-2'
          }
        }
        stage('Stage1-3') {
          steps {
            echo '1-3'
          }
        }
      }
    }
    stage('build') {
      parallel {
        stage('build') {
          steps {
            echo 'apple'
            sh '''UNITY_PATH=D:\\Unity
PROJECT_PATH=D:\\Create a ball
$UNITY_PATH -projectPath $PROJECT_PATH -executeMethod ProjectBuild.Build -batchmode -quit $@
'''
          }
        }
        stage('build2') {
          steps {
            echo 'apple2'
          }
        }
      }
    }
  }
}