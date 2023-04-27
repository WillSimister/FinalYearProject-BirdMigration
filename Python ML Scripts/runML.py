# Load libraries
from pandas import read_csv
from pandas.plotting import scatter_matrix
from matplotlib import pyplot
from sklearn.model_selection import train_test_split
from sklearn.model_selection import cross_val_score
from sklearn.model_selection import StratifiedKFold
from sklearn.metrics import classification_report
from sklearn.metrics import confusion_matrix
from sklearn.metrics import accuracy_score
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier
from sklearn.neighbors import KNeighborsClassifier
from sklearn.discriminant_analysis import LinearDiscriminantAnalysis
from sklearn.naive_bayes import GaussianNB
from sklearn.svm import SVC

chosenAlg = 'SVM'
# Load dataset
datasetPath = r'C:\MLExperimentFiles\New_ExpCSV.csv'
names = ['year', 'month', 'temp', 'name', 'type', 'country']
dataset = read_csv(datasetPath, names=names)

# Split-out validation dataset
array = dataset.values
X = array[:,0:2]
y = array[:,5]
X_train, X_validation, Y_train, Y_validation = train_test_split(X, y, test_size=0.20, random_state=1)
# Make predictions on validation dataset
#Select Chosen Model
if chosenAlg == 'LR':
	model = LogisticRegression(LogisticRegression(C=0.01, penalty='l1',solver='liblinear'))
elif chosenAlg == 'CART':
	model = DecisionTreeClassifier()
elif chosenAlg == 'LDA':
	model = LinearDiscriminantAnalysis()
elif chosenAlg == 'KNN':
	model = KNeighborsClassifier()
elif chosenAlg == 'SVM':
	model = SVC(gamma='auto')

model.fit(X_train, Y_train)
predictions = model.predict(X_validation)
# Evaluate predictions
print(accuracy_score(Y_validation, predictions))
print(confusion_matrix(Y_validation, predictions))
print(classification_report(Y_validation, predictions))