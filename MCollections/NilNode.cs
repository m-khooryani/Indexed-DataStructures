﻿namespace MCollections;

class NilNode<T> : Node<T>
{
    internal override bool IsNil() => true;
}
