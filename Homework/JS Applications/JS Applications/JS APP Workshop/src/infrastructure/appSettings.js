import secrets from '../../.secrets'

export default {
  contentContainerId: 'mainContent',
  loginContainer: 'loginContainer',
  baseUrl: secrets.databaseURL,
  firebaseConfig: {
    apiKey: secrets.apiKey,
    authDomain: secrets.authDomain,
    databaseURL: secrets.databaseURL,
    projectId: secrets.projectId,
    storageBucket: secrets.storageBucket,
    messagingSenderId: secrets.messagingSenderId,
    appId: secrets.appId
  },
  dataCollections: {
    todoCollection: 'todo',
    errorLogCollection: 'error_log'
  }
}