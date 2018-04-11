pipeline {
  agent any
  stages {
    stage('stage1') {
      parallel {
        stage('error') {
          steps {
            echo 'a'
          }
        }
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