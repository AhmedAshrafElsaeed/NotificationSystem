# Notification System

A simple console application that implements a Notification System using delegates and events in C#. This application demonstrates encapsulation, one of the fundamental pillars of Object-Oriented Programming (OOP).

## Technologies Used
- C#
- .NET Console Application

## Features
- ✅ Implements a Publisher-Subscriber model using events and delegates.
- ✅ Encapsulation is applied to protect class properties.
- ✅ Subscribers get notified when a new product is added to the market.
- ✅ Dynamic subscription and unsubscription of users.

## How It Works

### Market Class (Publisher)
- Maintains a list of products and subscribers.
- Fires an event (`ProductAdded`) whenever a new product is added.

### Subscriber Class (Observer)
- Listens for notifications from the market.
- Displays a message when notified.

### Main Program
- Creates `Market` and `Subscriber` objects.
- Subscribes users to the market.
- Adds products and notifies subscribers.
